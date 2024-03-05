using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelpLibrary.Models
{
    public class JournalEntryModel
    {
        /// <summary>
        /// The string with the writing for the journal entry. Inciated with " ".
        /// </summary>
        string JournalWriting = " ";

        /// <summary>
        /// Enum varianble with feeling chosen for the diary entry.
        /// </summary>
        PossibleFeeling Feeling;

        /// <summary>
        /// Enum with possible feelings that can be chosen by the user to describe their mood.
        /// </summary>
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
