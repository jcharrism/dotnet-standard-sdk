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

using System;
using System.Collections.Generic;
using IBM.WatsonDeveloperCloud.CompareComply.v1.Model;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1
{
    public partial interface ICompareComplyService
    {
        HTMLReturn HtmlConversion(System.IO.FileStream file, string modelId = null, Dictionary<string, object> customData = null);
        NLPReturn ElementClassification(System.IO.FileStream file, string modelId = null, Dictionary<string, object> customData = null);
        TablePayload Tables(System.IO.FileStream file, string modelId = null, Dictionary<string, object> customData = null);
        CompareReturn CompareDocuments(System.IO.FileStream file1, System.IO.FileStream file2, string file1Label = null, string file2Label = null, string modelId = null, string file1ContentType = null, string file2ContentType = null, Dictionary<string, object> customData = null);
        FeedbackCreated AddFeedback(FeedbackInput feedbackData, Dictionary<string, object> customData = null);
        BaseModel DeleteFeedback(string feedbackId, string modelId = null, Dictionary<string, object> customData = null);
        BaseModel GetFeedback(string feedbackId, string modelId = null, Dictionary<string, object> customData = null);
        BaseModel ListFeedback(string feedbackType = null, DateTime? before = null, DateTime? after = null, string documentTitle = null, string modelId = null, string modelVersion = null, string categoryRemoved = null, string categoryAdded = null, string categoryUnchanged = null, string typeRemoved = null, string typeAdded = null, string typeUnchanged = null, long? count = null, long? offset = null, string sort = null, Dictionary<string, object> customData = null);
        BatchStatusModel GetBatch(string batchId, Dictionary<string, object> customData = null);
        BatchStatusModel GetBatches(Dictionary<string, object> customData = null);
        BatchStatusModel PostBatch(string function, System.IO.FileStream inputCredentialsFile, string inputBucketLocation, string inputBucketName, System.IO.FileStream outputCredentialsFile, string outputBucketLocation, string outputBucketName, string modelId = null, Dictionary<string, object> customData = null);
        BatchStatusModel PutBatch(string batchId, string action, string modelId = null, Dictionary<string, object> customData = null);
    }
}
