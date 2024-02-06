using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLibrary
{
    public class JournalEntryModel
    {
        string JournalWriting = " ";
        PossibleFeeling Feeling;

        enum PossibleFeeling
        {
            Happy,
            Good,
            Alive,
            Meh,
            Stressed,
            Depressed,
            Lost,
            Crying
        }

    }
}
