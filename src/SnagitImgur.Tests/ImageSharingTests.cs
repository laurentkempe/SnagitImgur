﻿using System;
using Bddify;
using Bddify.Core;
using NUnit.Framework;

namespace SnagitImgur.Tests
{
    [Story]
    public class ImageSharingTests
    {
        [Test]
        public void Execute()
        {
            this.Bddify();
        }
    }
}
