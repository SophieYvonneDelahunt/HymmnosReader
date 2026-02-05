using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
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
        const string DATAFILE = "hymmnos_directory.txt";
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
            checkBoxAI.Enabled = false; // Disable complex search until implemented
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
            try
            {
                StreamReader reader = new StreamReader(DATAFILE);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (string.IsNullOrWhiteSpace(line))
                        continue;

                    var items = line.Split('\t');
                    if (items.Length != 5)
                        continue;

                    var word = new Word(items[0], items[1], items[2], items[3], items[4]);
                    words.Add(word);

                    dataGridViewInitial.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                    dataGridViewFiltered.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to parse .txt file. Ensure that hymmnos_directory.txt shares a directory with this application.\n\n" + e, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
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

            var lexiconStats = new StringBuilder();
            lexiconStats.AppendLine("Directory Statistics:");
            lexiconStats.AppendLine("-------------------------------------------------------------------");
            lexiconStats.AppendLine($"Total Records: {countTotal}");
            lexiconStats.AppendLine($"Central Standard Note Records: {countCentral}");
            lexiconStats.AppendLine($"New Testament of Pastalie Records: {countPastalie}");
            lexiconStats.AppendLine($"Metafalss Note Records: {countMetafalss}");
            lexiconStats.AppendLine($"Cluster Note Records: {countCluster}");
            lexiconStats.AppendLine($"Cult Ciel Note Records: {countCult}");
            lexiconStats.AppendLine($"Alpha Note (EOLIA) Records: {countAlpha}");
            lexiconStats.AppendLine($"Unofficial Note Records: {countUnofficial}");
            lexiconStats.AppendLine($"Asciydria Note Records: {countAsciydria}");
            lexiconStats.AppendLine($"Other Records: {countOther}");

            labelStats.Text = lexiconStats.ToString();
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
                if (((word.Dialect == "New Testament of Pastalie") || (word.Dialect == "Pastalie [Unofficial]")) && (noPastalie == true))
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
                if (((word.Dialect == "New Testament of Pastalie") || (word.Dialect == "Pastalie [Unofficial]")) && (noPastalie == true))
                {
                    continue;
                }
                else
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

        /// <summary>
        /// Allows the user to search for Hymmnos words. A checkbox element determines which sort type is used.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Contains event data.</param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxSearch.Text != "")
                {
                    dataGridViewFiltered.Rows.Clear();
                    string query = textBoxSearch.Text.ToLower();
                    if (checkBoxAI.Checked)
                    {
                        searchComplex(query);
                    }
                    else
                    {
                        searchSimple(query);
                    }
                }
                else
                {
                    labelSearchResults.Text = "Results:";
                    MessageBox.Show("Please enter a search term.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            catch (Exception ex)
            {
                labelSearchResults.Text = "Results:";
                MessageBox.Show("An error occurred during the search.\n\n" + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// Simple search function that matches words whose fields contain substrings.
        /// </summary>
        /// <param name="query">The search query provided by the user.</param>
        private void searchSimple(string query)
        {
            foreach (Word word in words)
            {
                if (word.Hymmnos.ToLower().Contains(query) || word.Meaning.ToLower().Contains(query) || word.ClassVar.ToLower().Contains(query) || word.Kana.ToLower().Contains(query) || word.Dialect.ToLower().Contains(query))
                {
                    if (((word.Dialect == "New Testament of Pastalie") || (word.Dialect == "Pastalie [Unofficial]")) && (noPastalie == true))
                    {
                        continue;
                    }
                    else
                    {
                        dataGridViewFiltered.Rows.Add(word.Hymmnos, word.Meaning, word.ClassVar, word.Kana, word.Dialect);
                    }
                }
            }
            labelSearchResults.Text = $"Results: {dataGridViewFiltered.Rows.Count}";
        }

        /// <summary>
        /// More complex search function that makes an API call to ChatGPT along with a .txt file containing the entire Hymmnos lexicon.
        /// The .txt file is called hymmnos_directory.txt and must be in the same directory as the application executable.
        /// The API key is stored in an environment variable named OPENAI_API_KEY.
        /// The assistant is asked to return only a comma-separated list of the Hymmnos words (first column) that best match the query.
        /// </summary>
        /// <param name="query">The search query provided by the user.</param>
        private void searchComplex(string query)
        {

        }
    }
}
