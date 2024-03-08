<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="AddQuestion.aspx.cs" Inherits="QuizzCraftClient.Views.AddQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

   
    <div>
        <h2>Add Question:</h2>
        <div>
            <label for="txtQuestion">Question Text:</label><br />
            <asp:RequiredFieldValidator ID="rfvQuestion" runat="server" ControlToValidate="txtQuestion" ErrorMessage="Question text is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><asp:TextBox ID="txtQuestion" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtCorrectAnswer">Correct Answer:</label>
            <asp:RequiredFieldValidator ID="rfvCorrectAnswer" runat="server" ControlToValidate="txtCorrectAnswer" ErrorMessage="Correct answer is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><asp:TextBox ID="txtCorrectAnswer" runat="server"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtOptionA">Option A:</label>
            <asp:RequiredFieldValidator ID="rfvOptionA" runat="server" ControlToValidate="txtOptionA" ErrorMessage="Option A is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><asp:TextBox ID="txtOptionA" runat="server"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtOptionB">Option B:</label>
            <asp:RequiredFieldValidator ID="rfvOptionB" runat="server" ControlToValidate="txtOptionB" ErrorMessage="Option B is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><asp:TextBox ID="txtOptionB" runat="server"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtOptionC">Option C:</label>
            <asp:RequiredFieldValidator ID="rfvOptionC" runat="server" ControlToValidate="txtOptionC" ErrorMessage="Option C is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><asp:TextBox ID="txtOptionC" runat="server"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtOptionD">Option D:</label>
            <asp:RequiredFieldValidator ID="rfvOptionD" runat="server" ControlToValidate="txtOptionD" ErrorMessage="Option D is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br /><asp:TextBox ID="txtOptionD" runat="server"></asp:TextBox><br />
        </div>
        <br />
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnAdd_Click" />
    </div>


        

</asp:Content>
