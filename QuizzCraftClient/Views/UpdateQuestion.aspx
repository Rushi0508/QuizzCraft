<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="UpdateQuestion.aspx.cs" Inherits="QuizzCraftClient.Views.UpdateQuestion" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Style.css" />

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <h2>Update Question:</h2>
        <div>
            <label for="txtQuestion">Question Text:</label><br />
            <asp:RequiredFieldValidator ID="rfvQuestion" runat="server" ControlToValidate="txtQuestion" ErrorMessage="Question text is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtQuestion" runat="server" TextMode="MultiLine" Rows="2"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtOptionA">Option A:</label>
            <asp:RequiredFieldValidator ID="rfvOptionA" runat="server" ControlToValidate="txtOptionA" ErrorMessage="Option A is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtOptionA" runat="server"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtOptionB">Option B:</label>
            <asp:RequiredFieldValidator ID="rfvOptionB" runat="server" ControlToValidate="txtOptionB" ErrorMessage="Option B is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtOptionB" runat="server"></asp:TextBox><br />
        </div>

        <div>
            <label for="txtOptionC">Option C:</label>
            <asp:RequiredFieldValidator ID="rfvOptionC" runat="server" ControlToValidate="txtOptionC" ErrorMessage="Option C is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtOptionC" runat="server"></asp:TextBox><br />
        </div>

        <br />
        <div>
            <label for="txtOptionD">Option D:</label>
            <asp:RequiredFieldValidator ID="rfvOptionD" runat="server" ControlToValidate="txtOptionD" ErrorMessage="Option D is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:TextBox ID="txtOptionD" runat="server"></asp:TextBox><br />
        </div>
        <br />

        <div>
            <label for="CorrectAnswer">Correct Answer:</label>
            <asp:DropDownList ID="CorrectAnswer" runat="server">
                <asp:ListItem Text="A" Value="A"></asp:ListItem>
                <asp:ListItem Text="B" Value="B"></asp:ListItem>
                <asp:ListItem Text="C" Value="C"></asp:ListItem>
                <asp:ListItem Text="D" Value="D"></asp:ListItem>
            </asp:DropDownList>
        </div>

           <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="updateButton"   OnClick="btnUpdateQuestion_Click" />
    </div>


</asp:Content>
