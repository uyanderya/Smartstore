﻿using Smartstore.Core.Configuration;

namespace Smartstore.Core.Common.Configuration
{
    public class PdfSettings : ISettings
    {
        /// <summary>
        /// Gets or sets a value indicating PDF is supported.
        /// </summary>
        public bool Enabled { get; set; } = true;

        /// <summary>
        /// PDF logo picture identifier.
        /// </summary>
        public int LogoPictureId { get; set; }

        /// <summary>
        /// Gets or sets whether letter page size is enabled.
        /// </summary>
        public bool LetterPageSizeEnabled { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to render order notes in PDf reports.
        /// </summary>
        public bool RenderOrderNotes { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether to attach the order PDF to 'Order Placed (customer)' email.
        /// </summary>
        public bool AttachOrderPdfToOrderPlacedEmail { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether to attach the order PDF to 'Order Completed (customer)' email.
        /// </summary>
        public bool AttachOrderPdfToOrderCompletedEmail { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of items to print.
        /// </summary>
        public int MaxItemsToPrint { get; set; } = 500;
    }
}
