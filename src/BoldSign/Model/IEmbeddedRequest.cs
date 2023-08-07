// <copyright file="IEmbeddedRequest.cs" company="Syncfusion Inc">
// Copyright (c) Syncfusion Inc. All rights reserved.
// </copyright>

namespace BoldSign.Model
{
    using System;

    /// <summary>
    /// The embedded send interface.
    /// </summary>
    public interface IEmbeddedRequest
    {
        /// <summary>
        /// Gets or sets the RedirectUrl.
        /// </summary>
        public Uri RedirectUrl { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show tool bar.
        /// </summary>
        public bool ShowToolbar { get; set; }

        /// <summary>
        /// Gets or sets the SendViewOption.
        /// </summary>
        public PageViewOption SendViewOption { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show save button.
        /// </summary>
        public bool ShowSaveButton { get; set; }

        /// <summary>
        /// Gets or sets the locale.
        /// </summary>
        public Locales Locale { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show send button.
        /// </summary>
        public bool ShowSendButton { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show preview button.
        /// </summary>
        public bool ShowPreviewButton { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show navigation buttons.
        /// </summary>
        public bool ShowNavigationButtons { get; set; }

        /// <summary>
        /// Gets or sets a value send link valid till.
        /// Maximum valid till is 180 days.
        /// Default is 30 days.
        /// </summary>
        public DateTime? SendLinkValidTill { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to show tooltip.
        /// </summary>
        public bool ShowTooltip { get; set; }
    }
}
