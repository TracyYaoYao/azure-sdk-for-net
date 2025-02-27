﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics
{
    /// <summary>
    /// The result of a <see cref="SingleLabelClassifyAction"/> or <see cref="MultiLabelClassifyAction"/> operation on a document,
    /// containing the collection of <see cref="ClassificationCategory"/> objects predicted for that document.
    /// </summary>
    public class ClassifyDocumentResult : TextAnalyticsResult
    {
        private readonly ClassificationCategoryCollection _classifications;
        internal ClassifyDocumentResult(string id, TextDocumentStatistics statistics, ClassificationCategoryCollection classifications, IReadOnlyCollection<TextAnalyticsWarning> warnings)
            : base(id, statistics)
        {
            _classifications = classifications;
            Warnings = warnings;
        }

        internal ClassifyDocumentResult(string id, TextAnalyticsError error) : base(id, error) { }

        /// <summary>
        /// Warnings encountered while processing the document.
        /// </summary>
        public IReadOnlyCollection<TextAnalyticsWarning> Warnings { get; }

        /// <summary>
        /// Gets the collection of <see cref="ClassificationCategory"/> objects predicted for the corresponding document.
        /// </summary>
        public ClassificationCategoryCollection ClassificationCategories
        {
            get
            {
                if (HasError)
                {
                    throw new InvalidOperationException($"Cannot access result for document {Id}, due to error {Error.ErrorCode}: {Error.Message}");
                }
                return _classifications;
            }
        }
    }
}
