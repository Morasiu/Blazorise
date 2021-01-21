﻿#region Using directives
using Blazorise.Utilities;
using Microsoft.AspNetCore.Components;
#endregion

namespace Blazorise
{
    public partial class TableFooter : BaseComponent
    {
        #region Members

        #endregion

        #region Methods

        protected override void BuildClasses( ClassBuilder builder )
        {
            builder.Append( ClassProvider.TableFooter() );

            base.BuildClasses( builder );
        }

        #endregion

        #region Properties

        [Parameter] public RenderFragment ChildContent { get; set; }

        #endregion
    }
}