<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register Assembly="DevExpress.Web.v15.2, Version=15.2.13.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
	<script type="text/javascript">
		var minFilterLength = 3,
            dataRequestTimer,
            dataRequestDelay = 500;

        function setData(val) {
            if (val === undefined || val === null) return;
            token.BeginUpdate();
            for (var i = 0, l = val.length; i < l; i++) 
                token.AddItem(val[i].ProductName, val[i].ProductID);            
            token.EndUpdate();
            token.ShowDropDown();
        }
        function keyUp(s, e) {
            var forbiddenCodes = [getCode("DOWN"), getCode("UP"), getCode("LEFT"), getCode("RIGHT"), getCode("HOME"), getCode("END")];
            if (forbiddenCodes.indexOf(e.htmlEvent.keyCode) > -1) return;
            clearTimeout(dataRequestTimer);
            clearItems();
            var inputValue = s.GetInputElement().value;
            if (inputValue.length >= minFilterLength) {
                dataRequestTimer = setTimeout(function () {
                    PageMethods.GetFilteredData(inputValue, setData);
                }, dataRequestDelay);
            }
        }
        function tokensChanged(s, e) {
            clearItems();
            token.HideDropDown();
        }
        function clearItems() {
            token.BeginUpdate();
            for (var i = 0, l = token.GetItemCount() ; i < l; i++)
                token.RemoveItem(0);
            token.EndUpdate();
        }
        function getCode(name) { return ASPxClientUtils.StringToShortcutCode(name); }
	</script>
	<form id="form1" runat="server">
		<div>
            Important note: after a search string will be inputed <br />
            only 10 items from the whole list of item match this filter creteria <br /> <br />
            Start type Cars, John, Jane, Michael, Lana and you will see how it works <br /> <br />

			<asp:ScriptManager ID="ScriptManager1" runat="server" EnablePageMethods="true"></asp:ScriptManager>
			<dx:ASPxTokenBox ID="TokenBox1" AllowCustomTokens="true" runat="server" ClientInstanceName="token" 
				ItemValueType="System.String" ValueField="ProductID"
				TextField="ProductName">
				<ClientSideEvents KeyUp="keyUp" TokensChanged="tokensChanged" />
			</dx:ASPxTokenBox>
		</div>
	</form>
</body>
</html>