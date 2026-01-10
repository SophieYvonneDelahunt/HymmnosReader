using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// >Sophie Delahunt
/// December 6, 2025
/// Personal Project - Hymmnos Reader
/// </summary>

namespace HymmnosReader
{
    /// <summary>
    /// Defines parameters for a <see cref="Word"/> object, used to represent a single word from the Hymmnos language.
    /// </summary>
    internal class Word
    {
        public string Hymmnos { get; set; }
        public string Meaning { get; set; }
        public string ClassVar { get; set; }
        public string Kana { get; set; }
        public string Dialect { get; set; }

        /// <summary>
        /// Constructor that initialises a new instance of the <see cref="Word"/> class with attributes.
        /// </summary>
        /// <param name="hymmnos">The Hymmnos word itself.</param>
        /// <param name="meaning">The word's meaning.</param>
        /// <param name="classVar">The class that the word belongs to (noun, verb, etc.).</param>
        /// <param name="kana">The kana of the word.</param>
        /// <param name="dialect">The regional dialect that the word originates from.</param>
        public Word(string hymmnos, string meaning, string classVar, string kana, string dialect)
        {
            Hymmnos = hymmnos;
            Meaning = meaning;
            ClassVar = classVar;
            Kana = kana;
            Dialect = dialect;
        }
    }
}
