using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.BLE.Abstractions.Contracts;
using Plugin.BLE.Abstractions.Exceptions;
using System.Collections.ObjectModel;
using Plugin.BLE;
using Plugin.SimpleAudioPlayer;
using System.IO;

namespace VocalVibes
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        IBluetoothLE ble;
        IAdapter adapter;
        ObservableCollection<IDevice> deviceList;
        IDevice device;
        private ISimpleAudioPlayer _simpleAudioPlayer;
        public MainPage()
        {
            InitializeComponent();
            BindVoiceList();
            this.BindingContext = this;
            ble = CrossBluetoothLE.Current;
            adapter = CrossBluetoothLE.Current.Adapter;
            deviceList = new ObservableCollection<IDevice>();
            voiceKeys keys = new voiceKeys();
            BindSoprano(keys);

            _simpleAudioPlayer = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
           // Stream beepStream = GetType().Assembly.GetManifestResourceStream("VocalVibes.beep.mp3");
            
            //bool isA1Success = _simpleAudioPlayer.Load(A1Stream);
        }
        private void PickVoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            voiceKeys VoiceKeys = new voiceKeys();
            var picker = sender as Picker;
            if (picker.SelectedIndex > -1)
            {
                switch (picker.SelectedItem)
                {
                    case "Soprano":
                        BindSoprano(VoiceKeys);
                        break;
                    case "Mezzo":
                        BindMezzo(VoiceKeys);
                        break;
                    case "Contralto":
                        BindContralto(VoiceKeys);
                        break;
                    case "Tenor":
                        BindTenor(VoiceKeys);
                        break;
                    case "Baritone":
                        BindBaritone(VoiceKeys);
                        break;
                    case "Bass":
                        BindBass(VoiceKeys);
                        break;
                }
            }
        }
        public void BindSoprano(voiceKeys VoiceKeys)
        {
            VoiceKeys.VBoxColor0 = "#FFF3F343";
            VoiceKeys.VBoxColor1 = "#FFE13838";
            VoiceKeys.VBoxColor2 = "Coral";
            VoiceKeys.VBoxColor3 = "#FF3DD328";

            VoiceKeys.VLabel01 = "A3";
            VoiceKeys.VLabel02 = "F4";
            VoiceKeys.VLabel11 = "F4";
            VoiceKeys.VLabel12 = "A4";
            VoiceKeys.VLabel21 = "A4";
            VoiceKeys.VLabel22 = "E5";
            VoiceKeys.VLabel31 = "E5";
            VoiceKeys.VLabel32 = "A5";

            BindKeys(VoiceKeys);
        }
        public void BindMezzo(voiceKeys VoiceKeys)
        {
            VoiceKeys.VBoxColor0 = "#F3B085";
            VoiceKeys.VBoxColor1 = "#AAD08D";
            VoiceKeys.VBoxColor2 = "#9AC1E9";
            VoiceKeys.VBoxColor3 = "#FC0100";

            VoiceKeys.VLabel01 = "E3";
            VoiceKeys.VLabel02 = "F4";
            VoiceKeys.VLabel11 = "F4";
            VoiceKeys.VLabel12 = "A4";
            VoiceKeys.VLabel21 = "A4";
            VoiceKeys.VLabel22 = "E5";
            VoiceKeys.VLabel31 = "E5";
            VoiceKeys.VLabel32 = "A5";

            BindKeys(VoiceKeys);
        }
        public void BindContralto(voiceKeys VoiceKeys)
        {
            VoiceKeys.VBoxColor0 = "#FFF3F343";
            VoiceKeys.VBoxColor1 = "#FFE13838";
            VoiceKeys.VBoxColor2 = "Coral";
            VoiceKeys.VBoxColor3 = "#FF3DD328";

            VoiceKeys.VLabel01 = "C3";
            VoiceKeys.VLabel02 = "E4";
            VoiceKeys.VLabel11 = "E4";
            VoiceKeys.VLabel12 = "G4";
            VoiceKeys.VLabel21 = "G4";
            VoiceKeys.VLabel22 = "D5";
            VoiceKeys.VLabel31 = "D5";
            VoiceKeys.VLabel32 = "G5";

            BindKeys(VoiceKeys);
        }
        public void BindTenor(voiceKeys VoiceKeys)
        {
            VoiceKeys.VBoxColor0 = "#F3B085";
            VoiceKeys.VBoxColor1 = "#AAD08D";
            VoiceKeys.VBoxColor2 = "#9AC1E9";
            VoiceKeys.VBoxColor3 = "#FC0100";

            VoiceKeys.VLabel01 = "A2";
            VoiceKeys.VLabel02 = "A3";
            VoiceKeys.VLabel11 = "A3";
            VoiceKeys.VLabel12 = "F4";
            VoiceKeys.VLabel21 = "F4";
            VoiceKeys.VLabel22 = "A4";
            VoiceKeys.VLabel31 = "A4";
            VoiceKeys.VLabel32 = "E5";

            BindKeys(VoiceKeys);
        }
        public void BindBaritone(voiceKeys VoiceKeys)
        {
            VoiceKeys.VBoxColor0 = "#FFF3F343";
            VoiceKeys.VBoxColor1 = "#FFE13838";
            VoiceKeys.VBoxColor2 = "Coral";
            VoiceKeys.VBoxColor3 = "#FF3DD328";

            VoiceKeys.VLabel01 = "E2";
            VoiceKeys.VLabel02 = "A3";
            VoiceKeys.VLabel11 = "A3";
            VoiceKeys.VLabel12 = "F4";
            VoiceKeys.VLabel21 = "F4";
            VoiceKeys.VLabel22 = "A4";
            VoiceKeys.VLabel31 = "A4";
            VoiceKeys.VLabel32 = "E5";

            BindKeys(VoiceKeys);
        }
        public void BindBass(voiceKeys VoiceKeys)
        {
            VoiceKeys.VBoxColor0 = "#F3B085";
            VoiceKeys.VBoxColor1 = "#AAD08D";
            VoiceKeys.VBoxColor2 = "#9AC1E9";
            VoiceKeys.VBoxColor3 = "#FC0100";

            VoiceKeys.VLabel01 = "C2";
            VoiceKeys.VLabel02 = "G3";
            VoiceKeys.VLabel11 = "G3";
            VoiceKeys.VLabel12 = "D4";
            VoiceKeys.VLabel21 = "D4";
            VoiceKeys.VLabel22 = "G4";
            VoiceKeys.VLabel31 = "G4";
            VoiceKeys.VLabel32 = "C5";

            BindKeys(VoiceKeys);
        }
        public void BindVoiceList()
        {
            pickVoice.Items.Add("Soprano");
            pickVoice.Items.Add("Mezzo");
            pickVoice.Items.Add("Contralto");
            pickVoice.Items.Add("Tenor");
            pickVoice.Items.Add("Baritone");
            pickVoice.Items.Add("Bass");

        }
        public void BindKeys(voiceKeys VoiceKeys)
        {
            VoiceKeys.HBox0 = "F6";
            VoiceKeys.HBox1 = "E6";
            VoiceKeys.HBox2 = "D6";
            VoiceKeys.HBox3 = "C6";
            VoiceKeys.HBox4 = "B5";
            VoiceKeys.HBox5 = "A5";
            VoiceKeys.HBox6 = "G5";
            VoiceKeys.HBox7 = "F5";
            VoiceKeys.HBox8 = "E5";
            VoiceKeys.HBox9 = "D5";
            VoiceKeys.HBox10 = "C5";
            VoiceKeys.HBox11 = "B4";
            VoiceKeys.HBox12 = "A4";
            VoiceKeys.HBox13 = "G4";
            VoiceKeys.HBox14 = "F4";
            VoiceKeys.HBox15 = "E4";
            VoiceKeys.HBox16 = "D4";
            VoiceKeys.HBox17 = "C4";
            VoiceKeys.HBox18 = "B3";
            VoiceKeys.HBox19 = "A3";
            VoiceKeys.HBox20 = "G3";
            VoiceKeys.HBox21 = "F3";
            VoiceKeys.HBox22 = "E3";
            VoiceKeys.HBox23 = "D3";
            VoiceKeys.HBox24 = "C3";
            VoiceKeys.HBox25 = "B2";
            VoiceKeys.HBox26 = "A2";
            VoiceKeys.HBox27 = "G2";
            VoiceKeys.HBox28 = "F2";
            VoiceKeys.HBox29 = "E2";
            VoiceKeys.HBox30 = "D2";
            VoiceKeys.HBox31 = "C2";

            VoiceKeys.shortKey11 = "D#6";
            VoiceKeys.shortKey12 = "Eb6";
            VoiceKeys.shortKey21 = "C#6";
            VoiceKeys.shortKey22 = "Db6";
            VoiceKeys.shortKey41 = "A#5";
            VoiceKeys.shortKey42 = "Bb5";
            VoiceKeys.shortKey51 = "G#5";
            VoiceKeys.shortKey52 = "Ab5";
            VoiceKeys.shortKey61 = "F#5";
            VoiceKeys.shortKey62 = "Gb5";
            VoiceKeys.shortKey81 = "D#5";
            VoiceKeys.shortKey82 = "Eb5";
            VoiceKeys.shortKey91 = "C#5";
            VoiceKeys.shortKey92 = "Db5";
            VoiceKeys.shortKey111 = "A#4";
            VoiceKeys.shortKey112 = "Bb4";
            VoiceKeys.shortKey121 = "G#4";
            VoiceKeys.shortKey122 = "Ab4";
            VoiceKeys.shortKey131 = "F#4";
            VoiceKeys.shortKey132 = "Gb4";
            VoiceKeys.shortKey151 = "D#4";
            VoiceKeys.shortKey152 = "Eb4";
            VoiceKeys.shortKey161 = "C#4";
            VoiceKeys.shortKey162 = "Db4";
            VoiceKeys.shortKey181 = "A#3";
            VoiceKeys.shortKey182 = "Bb3";
            VoiceKeys.shortKey191 = "G#3";
            VoiceKeys.shortKey192 = "Ab3";
            VoiceKeys.shortKey201 = "F#3";
            VoiceKeys.shortKey202 = "Gb3";
            VoiceKeys.shortKey221 = "D#3";
            VoiceKeys.shortKey222 = "Eb3";
            VoiceKeys.shortKey231 = "C#3";
            VoiceKeys.shortKey232 = "Db3";
            VoiceKeys.shortKey251 = "A#2";
            VoiceKeys.shortKey252 = "Bb2";
            VoiceKeys.shortKey261 = "G#2";
            VoiceKeys.shortKey262 = "Ab2";
            VoiceKeys.shortKey271 = "F#2";
            VoiceKeys.shortKey272 = "Gb2";
            VoiceKeys.shortKey291 = "D#2";
            VoiceKeys.shortKey292 = "Eb2";
            VoiceKeys.shortKey301 = "C#2";
            VoiceKeys.shortKey302 = "Db2";

            BindingContext = VoiceKeys;
        }
        void OnClicked(object sender, EventArgs e)
        {
            var btn = sender as Label;
            var text = btn.Text;
            if (btn.Text.Contains("#"))
            {
                text = btn.Text.Replace(@"#", string.Empty);
            }
            Stream stream = GetType().Assembly.GetManifestResourceStream("VocalVibes.Sounds."+ text + ".mp3");
            bool isSuccess = _simpleAudioPlayer.Load(stream);
            _simpleAudioPlayer.Play();
        }
    }
}
