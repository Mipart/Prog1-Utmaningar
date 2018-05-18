using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subways
{
    class subwayThree : subway
    {
        public subwayThree()
        {
            setup("Three");
            printSubwayShoutout();
            if (BoardTrain())
            {
                BoardTrainSelector(2);
            }
            else
            {
                BoardTrainSelector(4);
            }
        }
    }
}
