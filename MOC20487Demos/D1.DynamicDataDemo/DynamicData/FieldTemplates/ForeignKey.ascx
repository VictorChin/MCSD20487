<%@ Control Language="C#" CodeBehind="ForeignKey.ascx.cs" Inherits="D1.DynamicDataDemo.ForeignKeyField" %>

<asp:HyperLink ID="HyperLink1" runat="server"
    Text="<%# GetDisplayString() %>"
    NavigateUrl="<%# GetNavigateUrl() %>"  />

