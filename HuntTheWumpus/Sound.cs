using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Media;

namespace HuntTheWumpus
{
    public class Sound
    {
        public void pitSound()
        {
            SoundPlayer pit = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\fall.wav");
            pit.Play();
        }
        public void arrowSound()
        {
            SoundPlayer arrow = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\spear_trap.wav");
            arrow.Play();
        }
        public void arrowMissSound()
        {
            SoundPlayer arrow = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\miss.wav");
            arrow.Play();
        }
        public void earnGoldCoinsSound()
        {
            SoundPlayer earnGoldCoins = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\found_item.wav");
            earnGoldCoins.Play();
        }
        public void purchaseSound()
        {
            SoundPlayer purchase = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\click.wav");
            purchase.Play();
        }
        public void moveSound()
        {
            SoundPlayer move = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\step.wav");
            move.Play();
        }
        public void batSound()
        {
            SoundPlayer bats = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\bats.wav");
            bats.Play();
        }
        public void BGM()
        {
            SoundPlayer BGM = new SoundPlayer(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\Resources\\The Moon Night of Spring River.wav");
            BGM.PlayLooping();
        }
    }
}
