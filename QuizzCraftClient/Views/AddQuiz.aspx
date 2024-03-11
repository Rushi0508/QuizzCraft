<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="AddQuiz.aspx.cs" Inherits="QuizzCraftClient.Views.AddQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <asp:Label ID="TitleLabel" runat="server" AssociatedControlID="TitleTextBox" Text="Quiz Title:" /><asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="TitleTextBox" ErrorMessage="Quiz Title is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<br />
    <asp:TextBox ID="TitleTextBox" runat="server" /><br />

    <asp:Label ID="SubjectLabel" runat="server" AssociatedControlID="SubjectTextBox" Text="Quiz Subject:" /><asp:RequiredFieldValidator ID="rfvSubject" runat="server" ControlToValidate="SubjectTextBox" ErrorMessage="Quiz Subject is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<br />
    <asp:TextBox ID="SubjectTextBox" runat="server" /><br />

    <asp:Button ID="CreateButton" runat="server" Text="Create" OnClick="CreateQuizButton_Click" /><br />


</asp:Content>
