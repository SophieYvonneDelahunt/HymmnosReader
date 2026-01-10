using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// >Sophie Delahunt
/// December 6, 2025
/// Personal Project - Hymmnos Reader
/// </summary>

namespace HymmnosReader
{
    /// <summary>
    /// Defines functionality for the the application's user interface.
    /// </summary>
    public partial class HymmnosReaderInterface : Form
    {
        public SqlConnection Connection { get; private set; }
        string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=Hymmnoserver;Integrated Security=True";
        bool noPastalie = false;

        int countTotal = 0;
        int countCentral = 0;
        int countPastalie = 0;
        int countMetafalss = 0;
        int countCluster = 0;
        int countCult = 0;
        int countAlpha = 0;
        int countUnofficial = 0;
        int countAsciydria = 0;
        int countOther = 0;

        string defaultDef = "Parameter Definition:\nNone";
        string nounDef = "Parameter Definition:\nNoun - A person, place, thing, idea.";
        string verbDef = "Parameter Definition:\nVerb - An action or state of being.";
        string adjectiveDef = "Parameter Definition:\nAdjective - Describes or modifies a noun.";
        string adverbDef = "Parameter Definition:\nAdverb - Modifies a verb, adjective, or other adverb.";
        string prepositionDef = "Parameter Definition:\nPreposition - Shows relationships.";
        string conjunctionDef = "Parameter Definition:\nConjunction - Connects words, phrases, clauses.";
        string pronounDef = "Parameter Definition:\nPronoun - Replaces a noun.";
        string interjectionDef = "Parameter Definition:\nInterjection - Emotion/filler expression.";
        string particleDef = "Parameter Definition:\nParticle - A short function word used in phrasal verbs.";
        string constructDef = "Parameter Definition:\nConstruct - Marks words used chiefly in fixed grammatical\nconstructions, or forms used only inside set expressions.";
        string emotionverbDef = "Parameter Definition:\nEmotion-Verb - Verb whose behaviour or usage is tied to\nthe emotional components of Hymmnos.";
        string emotionsoundDef = "Parameter Definition:\nEmotion-Sound - Special prefix at the start of sentences that\nencode the speaker’s emotion.\nLevel I: Degree/intensity\nLevel II: Emotion type/nature\nLevel III: Context/desire-to-last/attitude";

        List<Word> words;

        /// <summary>
        /// Initialises the interface and creates empty lists of <see cref="Word"/> objects.
        /// </summary>
        public HymmnosReaderInterface()
        {
            InitializeComponent();
            words = new List<Word>();
            modUI();
            readData();
            printStats();
            labelDef.Text = defaultDef;
        }

        /// <summary>
        /// Makes a handful of visual tweaks not defined by the form designer tool.
        /// </summary>
        public void modUI()
        {
            dataGridViewInitial.EnableHeadersVisualStyles = false;
            dataGridViewInitial.Columns[0].HeaderCell.Style.BackColor = Color.DeepSkyBlue;
            dataGridViewInitial.Columns[1].HeaderCell.Style.BackColor = Color.LimeGreen;
            dataGridViewInitial.Columns[2].HeaderCell.Style.BackColor = Color.Gold;
            dataGridViewInitial.Columns[3].HeaderCell.Style.BackColor = Color.Violet;
            dataGridViewInitial.Columns[4].HeaderCell.Style.BackColor = Color.Salmon;

            dataGridViewFiltered.EnableHeadersVisualStyles = false;
            dataGridViewFiltered.Columns[0].HeaderCell.Style.BackColor = Color.DeepSkyBlue;
            dataGridViewFiltered.Columns[1].HeaderCell.Style.BackColor = Color.LimeGreen;
            dataGridViewFiltered.Columns[2].HeaderCell.Style.BackColor = Color.Gold;
            dataGridViewFiltered.Columns[3].HeaderCell.Style.BackColor = Color.Violet;
            dataGridViewFiltered.Columns[4].HeaderCell.Style.BackColor = Color.Salmon;
        }

        /// <summary>
        /// Populates the internal list of <see cref="Word"/> objects by pulling from the hymmnos_directory .txt file.
        /// Also loads words into the interface elements.
        /// </summary>
        public void readData()
        {
            const string DATAFILE = "hymmnos_directory.txt";
            try
            {
                StreamReader reader = new StreamReader(DATAFILE);
                while (!reader.EndOfStream)
                {
                    string[] items = reader.ReadLine().Split('	');
                    words.Add(new Word(items[0], items[1], items[2], items[3], items[4]));
                }
                reader.Close();

                foreach (Word word in words)
                {
                    dataGridViewInitial.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                    dataGridViewFiltered.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to parse .txt file.\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Prints statistics of the database to the interface.
        /// </summary>
        private void printStats()
        {
            foreach (Word word in words)
            {
                countTotal++;
                if (word.Dialect == "Central Standard Note")
                {
                    countCentral++;
                }
                else if (word.Dialect == "New Testament of Pastalie")
                {
                    countPastalie++;
                }
                else if (word.Dialect == "Metafalss Note")
                {
                    countMetafalss++;
                }
                else if (word.Dialect == "Cluster Note")
                {
                    countCluster++;
                }
                else if (word.Dialect == "Cult Ciel Note")
                {
                    countCult++;
                }
                else if (word.Dialect == "Alpha Note (EOLIA)")
                {
                    countAlpha++;
                }
                else if (word.Dialect.Contains("Unofficial"))
                {
                    countUnofficial++;
                }
                else if (word.Dialect == "Asciydria Note")
                {
                    countAsciydria++;
                }
                else
                {
                    countOther++;
                }
            }
            labelStats.Text = $"Directory Statistics:\n-------------------------------------------------------------------\nTotal Records: {countTotal}\nCentral Standard Note Records: {countCentral}\nNew Testament of Pastalie Records: {countPastalie}\nMetafalss Note Records: {countMetafalss}\nCluster Note Records: {countCluster}\nCult Ciel Note Records: {countCult}\nAlpha Note (EOLIA) Records: {countAlpha}\nUnofficial Note Records: {countUnofficial}\nAsciydria Note Records: {countAsciydria}\nOther Records: {countOther}";
        }

        /// <summary>.
        /// Loads words into the filtered ListView.
        /// </summary>
        /// <param name="wordType">The type of word that is being shown in the filtered view.</param>
        private void listSort(string wordType)
        {
            dataGridViewFiltered.Rows.Clear();
            foreach (Word word in words)
            {
                if (((word.Dialect == "New Testament of Pastalie")|| (word.Dialect == "Pastalie [Unofficial]")) && (noPastalie == true))
                {
                    continue;
                }
                else
                {
                    if (word.ClassVar.Contains($",{wordType}") || word.ClassVar.Contains($", {wordType}") || word.ClassVar.Contains($"{wordType},") || word.ClassVar == $"{wordType}")
                    {
                        dataGridViewFiltered.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                    }
                }
            }
        }

        /// <summary>
        /// Shows the user all stored <see cref="Word"/> objects.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonAll_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = defaultDef;
            dataGridViewFiltered.Rows.Clear();
            foreach (Word word in words)
                if ((word.Dialect == "New Testament of Pastalie") && (noPastalie == true))
                {
                    continue;
                } else
                {
                    dataGridViewFiltered.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                }
        }

        /// <summary>
        /// Shows the user only words that are nouns.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonNouns_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = nounDef;
            listSort("n.");
        }

        /// <summary>
        /// Shows the user only words that are verbs.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonVerbs_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = verbDef;
            listSort("v.");
        }

        /// <summary>
        /// Shows the user only words that are adjectives.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonAdjectives_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = adjectiveDef;
            listSort("adj.");
        }

        /// <summary>
        /// Shows the user only words that are prepositions.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonPrepositions_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = prepositionDef;
            listSort("prep.");
        }

        /// <summary>
        /// Shows the user only words that are conjunctions.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonConjunctions_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = conjunctionDef;
            listSort("conj.");
        }

        /// <summary>
        /// Shows the user only words that are adverbs.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonAdverbs_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = adverbDef;
            listSort("adv.");
        }

        /// <summary>
        /// Shows the user only words that are pronouns.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonPronouns_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = pronounDef;
            listSort("pron.");
        }

        /// <summary>
        /// Shows the user only words that are constructs.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonConstructs_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = constructDef;
            listSort("cnstr.");
        }

        /// <summary>
        /// Shows the user only words that are particles.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonParticles_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = particleDef;
            listSort("prt.");
        }

        /// <summary>
        /// Shows the user only words that are interjections.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonInterjections_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = interjectionDef;
            listSort("intj.");
        }

        /// <summary>
        /// Shows the user only words that are emotion-verbs.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonEmotionVerbs_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = emotionverbDef;
            listSort("E.V.");
        }

        /// <summary>
        /// Shows the user only words that are emotion-sounds.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void radioButtonEmotionSounds_CheckedChanged(object sender, EventArgs e)
        {
            labelDef.Text = emotionsoundDef;
            dataGridViewFiltered.Rows.Clear();
            foreach (Word word in words)
            {
                if (word.ClassVar.Contains($"E.S."))
                {
                    dataGridViewFiltered.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                }
            }
        }

        /// <summary>
        /// Allows the user to toggle the inclusion of the New Testament of Pastalie dialect, which can only be used on the Infel Phira server in Metafalss.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void checkBoxPastalie_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPastalie.Checked)
            {
                noPastalie = true;
            }
            else
            {
                noPastalie = false;
            }
            if (radioButtonAll.Checked)
                radioButtonAll_CheckedChanged(sender, e);
            else if (radioButtonNouns.Checked)
                radioButtonNouns_CheckedChanged(sender, e);
            else if (radioButtonVerbs.Checked)
                radioButtonVerbs_CheckedChanged(sender, e);
            else if (radioButtonAdjectives.Checked)
                radioButtonAdjectives_CheckedChanged(sender, e);
            else if (radioButtonPrepositions.Checked)
                radioButtonPrepositions_CheckedChanged(sender, e);
            else if (radioButtonConjunctions.Checked)
                radioButtonConjunctions_CheckedChanged(sender, e);
            else if (radioButtonAdverbs.Checked)
                radioButtonAdverbs_CheckedChanged(sender, e);
            else if (radioButtonPronouns.Checked)
                radioButtonPronouns_CheckedChanged(sender, e);
            else if (radioButtonConstructs.Checked)
                radioButtonConstructs_CheckedChanged(sender, e);
            else if (radioButtonParticles.Checked)
                radioButtonParticles_CheckedChanged(sender, e);
            else if (radioButtonInterjections.Checked)
                radioButtonInterjections_CheckedChanged(sender, e);
            else if (radioButtonEmotionVerbs.Checked)
                radioButtonEmotionVerbs_CheckedChanged(sender, e);
            else if (radioButtonEmotionSounds.Checked)
                radioButtonEmotionSounds_CheckedChanged(sender, e);
        }
    }
}
