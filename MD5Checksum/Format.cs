using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MD5Checksum
{
    class Format
    {
        /// <summary>
        /// Holds the data
        /// </summary>
        public class Data
        {
            /// <summary>
            /// File name
            /// </summary>
            public string file { get; set; }


            /// <summary>
            /// MD5 checksum for file
            /// </summary>
            public string md5 { get; set; }
        }


        /// <summary>
        /// Formats the Data list into a github table
        /// </summary>
        /// <param name="dataList">List of data</param>
        /// <returns>Returns table string</returns>
        public static string GithubTable(List<Data> dataList)
        {
            string table =
                "Binaries | MD5 Checksum\n"
                + "------------ | -------------\n";

            foreach (var item in dataList)
                table += $"{item.file} | {item.md5}\n";

            return table.Trim();
        }
    }
}
