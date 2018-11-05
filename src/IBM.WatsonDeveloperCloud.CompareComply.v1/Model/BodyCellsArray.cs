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

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.Model
{
    /// <summary>
    /// An array of column-level cells, each applicable as a header to other cells in the same column as itself, of the
    /// current table.
    /// </summary>
    public class BodyCellsArray : BaseModel
    {
        /// <summary>
        /// A string value in the format `columnHeader-x-y`, where `x` and `y` are the begin and end offsets of this
        /// column header cell in the input document.
        /// </summary>
        [JsonProperty("cell_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CellId { get; set; }
        /// <summary>
        /// The location of the column header cell in the current table as defined by its `begin` and `end` offsets,
        /// respectfully, in the input document.
        /// </summary>
        [JsonProperty("location", NullValueHandling = NullValueHandling.Ignore)]
        public object Location { get; set; }
        /// <summary>
        /// The textual contents of this cell from the input document without associated markup content.
        /// </summary>
        [JsonProperty("text", NullValueHandling = NullValueHandling.Ignore)]
        public string Text { get; set; }
        /// <summary>
        /// The `begin` index of this cell's `row` location in the current table.
        /// </summary>
        [JsonProperty("row_index_begin", NullValueHandling = NullValueHandling.Ignore)]
        public long? RowIndexBegin { get; set; }
        /// <summary>
        /// The `end` index of this cell's `row` location in the current table.
        /// </summary>
        [JsonProperty("row_index_end", NullValueHandling = NullValueHandling.Ignore)]
        public long? RowIndexEnd { get; set; }
        /// <summary>
        /// The `begin` index of this cell's `column` location in the current table.
        /// </summary>
        [JsonProperty("column_index_begin", NullValueHandling = NullValueHandling.Ignore)]
        public long? ColumnIndexBegin { get; set; }
        /// <summary>
        /// The `end` index of this cell's `column` location in the current table.
        /// </summary>
        [JsonProperty("column_index_end", NullValueHandling = NullValueHandling.Ignore)]
        public long? ColumnIndexEnd { get; set; }
        /// <summary>
        /// An array of values, each being the `id` value of a row header that is applicable to this body cell.
        /// </summary>
        [JsonProperty("row_header_ids", NullValueHandling = NullValueHandling.Ignore)]
        public object RowHeaderIds { get; set; }
        /// <summary>
        /// An array of values, each being the `cell_text` value of a row header that is applicable to this body cell.
        /// </summary>
        [JsonProperty("row_header_texts", NullValueHandling = NullValueHandling.Ignore)]
        public object RowHeaderTexts { get; set; }
        /// <summary>
        /// If you provide customization input, the normalized version of the row header texts according to the
        /// customization; otherwise, the same value as `row_header_texts`.
        /// </summary>
        [JsonProperty("row_header_texts_normalized", NullValueHandling = NullValueHandling.Ignore)]
        public object RowHeaderTextsNormalized { get; set; }
        /// <summary>
        /// An array of values, each being the `id` value of a column header that is applicable to this body cell.
        /// </summary>
        [JsonProperty("column_header_ids", NullValueHandling = NullValueHandling.Ignore)]
        public object ColumnHeaderIds { get; set; }
        /// <summary>
        /// An array of values, each being the `cell_text` value of a column header that is applicable to this body
        /// cell.
        /// </summary>
        [JsonProperty("column_header_texts", NullValueHandling = NullValueHandling.Ignore)]
        public object ColumnHeaderTexts { get; set; }
        /// <summary>
        /// If you provide customization input, the normalized version of the column header texts according to the
        /// customization; otherwise, the same value as `column_header_texts`.
        /// </summary>
        [JsonProperty("column_header_texts_normalized", NullValueHandling = NullValueHandling.Ignore)]
        public object ColumnHeaderTextsNormalized { get; set; }
    }

}
