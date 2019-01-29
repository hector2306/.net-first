using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Homework1
{
    public class Television : Electro_domestic
    {
        private int channels;
        private int display_size;

        public Television()
        {
            base();

        }
        public Television(int channels, int display_size)
        {
            base();
            this.channels = channels;
            this.display_size = display_size;
        }

        public void changeChannels(int channels)
        {
            this.channels = channels;
        }

        public int chackChannels()
        {
            return this.channels;
        }
    }

}
