/**
* Copyright 2017 IBM Corp. All Rights Reserved.
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
using System.IO;
using IBM.WatsonDeveloperCloud.Util;
using IBM.WatsonDeveloperCloud.CompareComply.v1.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace IBM.WatsonDeveloperCloud.CompareComply.v1.IT
{
    [TestClass]
    public class CompareComplyServiceIntegrationTests
    {
        private static string apikey;
        private static string endpoint;
        private CompareComplyService service;
        private static string credentials = string.Empty;
        private readonly string versionDate = "2018-11-05";
        private string _pdfFilepath = @"CompareComplyTestData/jabberwocky.pdf";
        private string _pdfTableFilepath = @"CompareComplyTestData/table.pdf";

        [TestInitialize]
        public void Setup()
        {
            #region Get Credentials
            if (string.IsNullOrEmpty(credentials))
            {
                //var parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.Parent.FullName;
                //string credentialsFilepath = parentDirectory + Path.DirectorySeparatorChar + "sdk-credentials" + Path.DirectorySeparatorChar + "credentials.json";
                //if (File.Exists(credentialsFilepath))
                //{
                //    try
                //    {
                //        credentials = File.ReadAllText(credentialsFilepath);
                //        credentials = Utility.AddTopLevelObjectToJson(credentials, "VCAPserviceS");
                //    }
                //    catch (Exception e)
                //    {
                //        throw new Exception(string.Format("Failed to load credentials: {0}", e.Message));
                //    }
                //}
                //else
                //{
                //    Console.WriteLine("Credentials file does not exist.");
                //}

                //VcapCredentials vcapCredentials = JsonConvert.DeserializeObject<VcapCredentials>(credentials);
                //var vcapServices = JObject.Parse(credentials);

                //Credential credential = vcapCredentials.GetCredentialByname("compare-comply-sdk")[0].Credentials;
                //endpoint = credential.Url;
                //apikey = credential.IamApikey;

                endpoint = "https://gateway-s.watsonplatform.net/compare-comply/api";
                apikey = "PT893iB3ZNfkq6Rovm6cTeAeYCQ5W8_Hy5qvZuQJK_jR";
            }
            #endregion

            TokenOptions tokenOptions = new TokenOptions()
            {
                IamApiKey = apikey,
                ServiceUrl = endpoint,
                IamUrl = "https://iam.stage1.bluemix.net/identity/token"
            };
            service = new CompareComplyService(tokenOptions, versionDate);
            service.SetEndpoint(endpoint);
        }

        #region HTML Conversion
        [TestMethod]
        public void HtmlConversion_Success()
        {
            HTMLReturn htmlConversionResults = null;
            using (FileStream fs = File.OpenRead(_pdfFilepath))
            {
                htmlConversionResults = HtmlConversion(fs);
            }
            Assert.IsNotNull(htmlConversionResults);
        }
        #endregion

        #region Element Classification
        [TestMethod]
        public void ElementClassification_Success()
        {
            NLPReturn elementClassificationResults = null;
            using (FileStream fs = File.OpenRead(_pdfFilepath))
            {
                elementClassificationResults = ElementClassification(fs);
            }
            Assert.IsNotNull(elementClassificationResults);
        }
        #endregion

        #region Tables
        [TestMethod]
        public void Tables_Success()
        {
            TablePayload tablesResults = null;
            using (FileStream fs = File.OpenRead(_pdfTableFilepath))
            {
                tablesResults = Tables(fs);
            }
            Assert.IsNotNull(tablesResults);
        }
        #endregion

        #region Comparision
        [TestMethod]
        public void Comparision_Success()
        {
            CompareReturn compareResults = null;
            using (FileStream fs1 = File.OpenRead(_pdfFilepath))
            {
                using (FileStream fs2 = File.OpenRead(_pdfTableFilepath))
                {
                    compareResults = CompareDocuments(fs1, fs2);
                }
            }

            Assert.IsNotNull(compareResults);

        }
        #endregion

        #region Feedback
        [TestMethod]
        public void Feedback_Success()
        {
            var listFeedbackResults = ListFeedback();

            FeedbackInput feedbackData = new FeedbackInput()
            {
                
            };
            var addFeedbackResults = AddFeedback(feedbackData);
            var feedbackId = addFeedbackResults.FeedbackId;
            var getFeedbackResults = GetFeedback(feedbackId);
            var deleteFeedbackResults = DeleteFeedback(feedbackId);

            Assert.IsNotNull(deleteFeedbackResults);
            Assert.IsNotNull(getFeedbackResults);
            Assert.IsNotNull(addFeedbackResults);
            Assert.IsNotNull(listFeedbackResults);
        }
        #endregion

        #region Batches
        [TestMethod]
        public void Batches_Success()
        {
            var listBatchesResults = GetBatches();

            var parentDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.Parent.Parent.FullName;
            string credentialsFilepath = parentDirectory + Path.DirectorySeparatorChar + "sdk-credentials" + Path.DirectorySeparatorChar + "cloud-object-storage-credentials.json";
            BatchStatusModel submitBatchResults = null;
            if (File.Exists(credentialsFilepath))
            {

                using (FileStream fs = File.OpenRead(credentialsFilepath))
                {
                    submitBatchResults = PostBatch("html_conversion", fs, "us-geo", "compare-comply-integration-test-bucket-input", fs, "us-geo", "compare-comply-integration-test-bucket-output");
                }
            }

            var batchId = submitBatchResults.BatchId;
            var getBatchResult = GetBatch(batchId);
            var putBatchResult = PutBatch(batchId, "rescan");

            Assert.IsNotNull(putBatchResult);
            Assert.IsNotNull(getBatchResult);
            Assert.IsNotNull(submitBatchResults);
            Assert.IsNotNull(listBatchesResults);
        }
        #endregion

        #region Generated
        #region HtmlConversion
        private HTMLReturn HtmlConversion(System.IO.FileStream file, string modelId = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to HtmlConversion()");
            var result = service.HtmlConversion(file: file, modelId: modelId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("HtmlConversion() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to HtmlConversion()");
            }

            return result;
        }
        #endregion

        #region ElementClassification
        private NLPReturn ElementClassification(System.IO.FileStream file, string modelId = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to ElementClassification()");
            var result = service.ElementClassification(file: file, modelId: modelId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("ElementClassification() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to ElementClassification()");
            }

            return result;
        }
        #endregion

        #region Tables
        private TablePayload Tables(System.IO.FileStream file, string modelId = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to Tables()");
            var result = service.Tables(file: file, modelId: modelId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("Tables() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to Tables()");
            }

            return result;
        }
        #endregion

        #region CompareDocuments
        private CompareReturn CompareDocuments(System.IO.FileStream file1, System.IO.FileStream file2, string file1Label = null, string file2Label = null, string modelId = null, string file1ContentType = null, string file2ContentType = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to CompareDocuments()");
            var result = service.CompareDocuments(file1: file1, file2: file2, file1Label: file1Label, file2Label: file2Label, modelId: modelId, file1ContentType: file1ContentType, file2ContentType: file2ContentType, customData: customData);

            if (result != null)
            {
                Console.WriteLine("CompareDocuments() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to CompareDocuments()");
            }

            return result;
        }
        #endregion

        #region AddFeedback
        private FeedbackCreated AddFeedback(FeedbackInput feedbackData, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to AddFeedback()");
            var result = service.AddFeedback(feedbackData: feedbackData, customData: customData);

            if (result != null)
            {
                Console.WriteLine("AddFeedback() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to AddFeedback()");
            }

            return result;
        }
        #endregion

        #region DeleteFeedback
        private BaseModel DeleteFeedback(string feedbackId, string modelId = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to DeleteFeedback()");
            var result = service.DeleteFeedback(feedbackId: feedbackId, modelId: modelId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("DeleteFeedback() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to DeleteFeedback()");
            }

            return result;
        }
        #endregion

        #region GetFeedback
        private BaseModel GetFeedback(string feedbackId, string modelId = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to GetFeedback()");
            var result = service.GetFeedback(feedbackId: feedbackId, modelId: modelId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("GetFeedback() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to GetFeedback()");
            }

            return result;
        }
        #endregion

        #region ListFeedback
        private BaseModel ListFeedback(string feedbackType = null, DateTime? before = null, DateTime? after = null, string documentTitle = null, string modelId = null, string modelVersion = null, string categoryRemoved = null, string categoryAdded = null, string categoryUnchanged = null, string typeRemoved = null, string typeAdded = null, string typeUnchanged = null, long? count = null, long? offset = null, string sort = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to ListFeedback()");
            var result = service.ListFeedback(feedbackType: feedbackType, before: before, after: after, documentTitle: documentTitle, modelId: modelId, modelVersion: modelVersion, categoryRemoved: categoryRemoved, categoryAdded: categoryAdded, categoryUnchanged: categoryUnchanged, typeRemoved: typeRemoved, typeAdded: typeAdded, typeUnchanged: typeUnchanged, count: count, offset: offset, sort: sort, customData: customData);

            if (result != null)
            {
                Console.WriteLine("ListFeedback() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to ListFeedback()");
            }

            return result;
        }
        #endregion

        #region GetBatch
        private BatchStatusModel GetBatch(string batchId, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to GetBatch()");
            var result = service.GetBatch(batchId: batchId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("GetBatch() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to GetBatch()");
            }

            return result;
        }
        #endregion

        #region GetBatches
        private BatchStatusModel GetBatches(Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to GetBatches()");
            var result = service.GetBatches(customData: customData);

            if (result != null)
            {
                Console.WriteLine("GetBatches() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to GetBatches()");
            }

            return result;
        }
        #endregion

        #region PostBatch
        private BatchStatusModel PostBatch(string function, System.IO.FileStream inputCredentialsFile, string inputBucketLocation, string inputBucketName, System.IO.FileStream outputCredentialsFile, string outputBucketLocation, string outputBucketName, string modelId = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to PostBatch()");
            var result = service.PostBatch(function: function, inputCredentialsFile: inputCredentialsFile, inputBucketLocation: inputBucketLocation, inputBucketName: inputBucketName, outputCredentialsFile: outputCredentialsFile, outputBucketLocation: outputBucketLocation, outputBucketName: outputBucketName, modelId: modelId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("PostBatch() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to PostBatch()");
            }

            return result;
        }
        #endregion

        #region PutBatch
        private BatchStatusModel PutBatch(string batchId, string action, string modelId = null, Dictionary<string, object> customData = null)
        {
            Console.WriteLine("\nAttempting to PutBatch()");
            var result = service.PutBatch(batchId: batchId, action: action, modelId: modelId, customData: customData);

            if (result != null)
            {
                Console.WriteLine("PutBatch() succeeded:\n{0}", JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            else
            {
                Console.WriteLine("Failed to PutBatch()");
            }

            return result;
        }
        #endregion

        #endregion
    }
}
