using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Plugin.SimpleAudioPlayer;

namespace IHaveADream {
    public partial class MainPage : ContentPage {

        //initialize audio players for each speech
        ISimpleAudioPlayer playerMLK = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();
        ISimpleAudioPlayer playerMalcolmX = CrossSimpleAudioPlayer.CreateSimpleAudioPlayer();

        public MainPage() {
            InitializeComponent();

            //on initialization, load the speech audio into the players
            playerMLK.Load("mlk.mp3");
            playerMalcolmX.Load("malcolmx.mp3");
        }

        //event handler for MLK button on click
        //when the button is clicked:
        private void btnMLK_Clicked(object sender, EventArgs e) {
            if (playerMLK.IsPlaying) {//if the MLK speech is playing, pause it
                playerMLK.Pause();
            } else { //otherwise:
                if (playerMalcolmX.IsPlaying) { //if the malcolmx speech is playing:
                    playerMalcolmX.Pause();//pause the malcolm x speech
                }

                playerMLK.Play(); //then play the MLK speech
            }
        }

        //event handler for MalcolmX button on click
        private void btnMalcolmX_Clicked(object sender, EventArgs e) {
            //pause MalcolmX if playing, otherwise pause MLK if playing and play MalcolmX.
            if (playerMalcolmX.IsPlaying) {
                playerMalcolmX.Pause();
            } else {
                if (playerMLK.IsPlaying) {
                    playerMLK.Pause();
                }

                playerMalcolmX.Play();
            }
        }
    }
}
