using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subways
{
    class subwayOne : subway //subwayOne ärver från subway, så alla public metoder kan nås igenom denna class
    {
        public subwayOne()
        {
            setup("One");
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
