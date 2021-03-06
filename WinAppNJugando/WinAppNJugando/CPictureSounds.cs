﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace RegiAnimal
{
    class CPictureSounds
    {
        SoundPlayer player;

        public void playSound(PictureBox picSound)
        {
            player = new SoundPlayer(Application.StartupPath + @"/Audio/"+ (String)picSound.Tag +".wav");
            player.Play();
        }
        public void playSound(PictureBox picSound, String cases)
        {
            player = new SoundPlayer(Application.StartupPath + @"/Audio/" + cases + ".wav");
            player.Play();
        }
        public void playSound(String cases)
        {
            player = new SoundPlayer(Application.StartupPath + @"/Audio/" + cases + ".wav");
            player.Play();
        }
        public void playIntro()
        {
            player = new SoundPlayer(Application.StartupPath + @"/Audio/intro.wav");
            player.Play();
        }

        public void playIntruction()
        {
            player = new SoundPlayer(Application.StartupPath + @"/Audio/instruction.wav");
            player.Play();
        }

        public void playHelp()
        {
            player = new SoundPlayer(Application.StartupPath + @"/Audio/HelpRegi.wav");
            player.Play();
        }
    }
}
