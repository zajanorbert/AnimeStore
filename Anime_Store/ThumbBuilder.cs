using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Anime_Store
{
    class ThumbBuilder : MainWindow
    {
        private List<Thumbnail> tempThumb = new List<Thumbnail>() 
        { 
            new Thumbnail("https://cdnimg.xyz/images/anime/One-piece.jpg", "One Piece"),
            new Thumbnail("https://cdnimg.xyz/cover/sword-art-online-alicization-war-of-underworld.png", "Sword Art Online"),
            new Thumbnail("https://cdnimg.xyz/cover/vinland-saga.png", "Vinland Saga"),
            new Thumbnail("https://cdnimg.xyz/cover/no-guns-life.png", "No Guns Life"),
            new Thumbnail("https://cdnimg.xyz/cover/death-note-dub.png", "Death Note"),
            new Thumbnail("https://cdnimg.xyz/images/summer/akame_ga_kill.jpg", "Akame ga Kill!"),
            new Thumbnail("https://cdnimg.xyz/cover/enen-no-shouboutai.png", "EnEn no Shouboutai"),
            new Thumbnail("https://cdnimg.xyz/images/anime/G/gantz.jpg", "Gantz"),
            new Thumbnail("https://cdnimg.xyz/images/anime/J/JoJo-Bizarre-Adventure.jpg", "JoJo`s Bizarre Adventure"),
            new Thumbnail("https://cdnimg.xyz/images/upload/179004.jpg", "Boku dake ga Inai Machi"),
            new Thumbnail("https://cdnimg.xyz/cover/dr-stone.png", "Dr Stone"),
            new Thumbnail("https://cdnimg.xyz/images/anime/T/tokyo-mew-mew.jpg", "Tokyo mew mew"),
            new Thumbnail("https://cdnimg.xyz/cover/black-clover-tv.png", "Black Clover"),
        };

        public ThumbBuilder()
        {
            
        }

        /// <summary>
        /// Building XAML code for the Main Grid View.
        /// </summary>
        public void elementBuilder()
        {
          

            

        }


    }
}
