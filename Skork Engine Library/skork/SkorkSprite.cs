using System.Windows;
using System.Windows.Controls;

namespace Skork_Engine_Library.skork {
    public class SkorkSprite {

        private string name;
        private Image spriteImg;
        private Point position;

        public SkorkSprite(string name) {
            this.name = name;
            this.position = new Point(0, 0);
            this.spriteImg = new Image();
        }
        public SkorkSprite(string name, Point position) {
            this.name = name;
            this.position = position;
            this.spriteImg = new Image();
        }

    }
}
