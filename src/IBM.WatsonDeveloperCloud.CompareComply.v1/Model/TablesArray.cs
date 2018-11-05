/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using System.Collections.Generic;
using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.Model
{
    /// <summary>
    /// An object describing the contents of the tables extracted from a document.
    /// </summary>
    public class TablesArray : BaseModel
    {
        /// <summary>
        /// The location of the current table in the input document, as defined by its `begin` and `end` character
        /// offset values.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public object Location { get; set; }
        /// <summary>
        /// The textual contents of the current table from the input document without associated markup content.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// If identified, the location of a section title containing the current table, as defined by its begin and end
        /// offsets in the original input document. Empty if no section title is identified.
        /// </summary>
        [JsonProperty("section_title", NullValueHandling = NullValueHandling.Ignore)]
        public object SectionTitle { get; set; }
        /// <summary>
        /// An array of table-level cells applicable as headers to all of the other cells of the current table. Each
        /// table header is defined as a collection of other elements.
        /// </summary>
        [JsonProperty("table_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<TableHeadersArray> TableHeaders { get; set; }
        /// <summary>
        /// An array of row-level cells, each applicable as a header to other cells in the same row as itself, of the
        /// current table. Each row header is defined as a collection of other elements.
        /// </summary>
        [JsonProperty("row_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<RowHeadersArray> RowHeaders { get; set; }
        /// <summary>
        /// An array of column-level cells, each applicable as a header to other cells in the same column as itself, of
        /// the current table. Each column header is defined as a collection of other elements.
        /// </summary>
        [JsonProperty("column_headers", NullValueHandling = NullValueHandling.Ignore)]
        public List<ColumnHeadersArray> ColumnHeaders { get; set; }
        /// <summary>
        /// An array of cells that are neither table header nor column header nor row header cells, of the current table
        /// with corresponding row and column header associations. Each body cell is defined as a collection of other
        /// elements.
        /// </summary>
        [JsonProperty("body_cells", NullValueHandling = NullValueHandling.Ignore)]
        public List<BodyCellsArray> BodyCells { get; set; }
    }

}
