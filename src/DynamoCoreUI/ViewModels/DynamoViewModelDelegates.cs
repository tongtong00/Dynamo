﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Dynamo.Models;
using Dynamo.PackageManager;

namespace Dynamo.ViewModels
{
    public delegate void ImageSaveEventHandler(object sender, ImageSaveEventArgs e);

    public delegate void WorkspaceSaveEventHandler(object sender, WorkspaceSaveEventArgs e);

    public delegate void RequestPackagePublishDialogHandler(PublishPackageViewModel publishViewModel);

    public delegate void RequestAboutWindowHandler(DynamoViewModel aboutViewModel);

    public delegate void RequestViewOperationHandler(ViewOperationEventArgs e);

}