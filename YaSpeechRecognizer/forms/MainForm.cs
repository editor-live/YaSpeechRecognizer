using Grpc.Net.Client;
using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Speechkit.Stt.V3;
using Grpc.Core;
using System.Threading;

using classes;
using System.IO;
using static Grpc.Core.ServerServiceDefinition;
using YaSpeechRecognizer.classes;

namespace YaSpeechRecognizer.forms
{
    public partial class MainForm : Form
    {
        private DateTime _iamTokenExperiesAt = DateTime.MinValue;
        private int _recognizeCount = 0;
        private TimeSpan _totalRecognizeTime = TimeSpan.Zero;

        private SoundRecorder _soundRecorder;
        private SoundPlayer _player;
        private YandexRecognizer _voiceRecognizer;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _soundRecorder = new SoundRecorder();
            _player = new SoundPlayer();
            _voiceRecognizer = new YandexRecognizer(new EasyLoggerFactory());
            LoadSettings();
            CheckIamTokenDate();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void button_Record_MouseDown(object sender, MouseEventArgs e)
        {
            StartRecordingRecognize();
        }

        private async void button_Record_MouseUp(object sender, MouseEventArgs e)
        {
            StopRecognizeText();
        }

        public void StartRecordingRecognize()
        {
            Task.Run(() => Console.Beep(500, 100));

            if (!CheckIamTokenDate())
            {
                MessageBox.Show("Задайте новый iamToken", "Срок действия токена истек!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox_iamToken.Text == string.Empty)
            {
                MessageBox.Show("Задайте новый iamToken", "Нет авторизации на сервисе", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _soundRecorder.StartRecordingStream();

            button_Record.BackColor = Color.Red;
            Console.Beep();
        }

        internal string StopRecognizeText()
        {
            button_Record.BackColor = Color.White;

            MemoryStream stream = _soundRecorder.StopStreamRecording();

            _totalRecognizeTime += _soundRecorder.LastRecordedSoundTime;

            if (stream == null) return null;

            string result = null;

            if (checkBox_Replay.Checked) _player.PlaySound(stream, (float)0.2);

            try {
                result = _voiceRecognizer.Recognize(stream.ToArray(), textBox_iamToken.Text, textBox_FolderId.Text);
            }
            catch (Exception e)
            {
                Console.Beep(2000, 500);
                MessageBox.Show(e.ToString(), "Ошибка распознования!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

            this.Text = $"Recognize counter:{++_recognizeCount}, time:{_totalRecognizeTime.ToString(@"mm\:ss")}, start:{_voiceRecognizer.StartCount}";

            MessageBox.Show(result);

            return result;
        }

        private async void button_GetToken_Click(object sender, EventArgs e)
        {
            try
            {
                YandexAuthToken.iamTokenResult token = await new YandexAuthToken().getIamToken(textBox_AuthCode.Text);
                if (token == null) { return; }
                if (token.iamToken == null)
                {
                    MessageBox.Show($"ERROR!, {token.message}");
                    return;
                }

                textBox_iamToken.Text = token.iamToken;
                DateTime.TryParse(token.expiresAt, out _iamTokenExperiesAt);
                MessageBox.Show($"OK, expiresAt:{token.expiresAt}");
                CheckIamTokenDate();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.ToString());
            }
        }

        private bool CheckIamTokenDate()
        {
            if (_iamTokenExperiesAt >= DateTime.Now)
            {
                textBox_iamToken.BackColor = Color.White;
                return true;
            }
            else
            {
                textBox_iamToken.BackColor = Color.Red;
                return false;
            }
        }

        public void LoadSettings()
        {
            textBox_FolderId.Text = Properties.Settings.Default.speechRec_folderID;
            textBox_iamToken.Text = Properties.Settings.Default.speechRec_iamToken;
            textBox_AuthCode.Text = Properties.Settings.Default.speechRec_authCode;
            _iamTokenExperiesAt = Properties.Settings.Default.speechRec_iamTokenExperiesTime;
            checkBox_AutoToken.Checked = Properties.Settings.Default.speechRec_AutoNewToken;
            if (!CheckIamTokenDate() && checkBox_AutoToken.Checked)
                button_GetToken_Click(null, null);
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.speechRec_folderID = textBox_FolderId.Text;
            Properties.Settings.Default.speechRec_iamToken = textBox_iamToken.Text;
            Properties.Settings.Default.speechRec_authCode = textBox_AuthCode.Text;
            Properties.Settings.Default.speechRec_iamTokenExperiesTime = _iamTokenExperiesAt;
            Properties.Settings.Default.speechRec_AutoNewToken = checkBox_AutoToken.Checked;
            Properties.Settings.Default.Save();
        }

        private void Label_YandexSpeechKit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://yandex.cloud/ru/services/speechkit");
        }

        private void Label_YandexDocumentation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://yandex.cloud/ru/docs/speechkit/overview");
        }
    }
}
