﻿using CMS.DataEngine;
using Kentico.Forms.Web.Mvc;

namespace MyCompany.Components.Models
{
    public class ImageUrlWithPreviewProperties : FormComponentProperties<string>
    {
        [DefaultValueEditingComponent(ImageUrlWithPreviewComponent.IDENTIFIER)]
        public override string DefaultValue { get; set; }


        public ImageUrlWithPreviewProperties()
           : base(FieldDataType.Text, 500)
        {
        }
    }
}