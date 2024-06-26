<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128531304/15.1.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T457341)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Token Box for ASP.NET Web Forms - How to bind the control to a large data source
This example demonstrates how to bind the [ASPxTokenBox](https://docs.devexpress.com/AspNet/16295/components/data-editors/tokenbox) control to a large data source on the client side.

![Bind Token Box to Large Data](result.png)

## Overview

The client-side [KeyUp](https://docs.devexpress.com/AspNet/js-ASPxClientTextEdit.KeyUp) event occurs after a user enters a character in the token box. In this example, this event's handler performs the following actions when 3 or more characters are entered:

1. Clears the control's token collection.
2. Searches the data source for items that include the entered text.
3. Populates the token box with found items.

Once a user selects a token, the [TokensChanged](https://docs.devexpress.com/AspNet/js-ASPxClientTokenBox.TokensChanged) event occurs. The event handler clears the token collection and hides the control's drop-down window.

Note that some code sections in this example are enclosed in the [BeginUpdate](https://docs.devexpress.com/AspNet/js-ASPxClientComboBox.BeginUpdate) - [EndUpdate](https://docs.devexpress.com/AspNet/js-ASPxClientComboBox.EndUpdate) method calls. These methods allow event handlers to process a batch of changes in token box settings without intermediate updates. You can disable the [AllowCustomTokens](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxTokenBox.AllowCustomTokens) property and change the [IncrementalFilteringDelay](https://docs.devexpress.com/AspNet/DevExpress.Web.ASPxAutoCompleteBoxBase.IncrementalFilteringDelay) property value to adapt this example to your business requirements.

## Files to Review

* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))

## Documentation

- [Bind Editors to Data](https://docs.devexpress.com/AspNet/3787/components/data-editors/common-concepts/binding-to-data?p=netframework)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-token-box-bind-editor-to-large-data&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-web-forms-token-box-bind-editor-to-large-data&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
