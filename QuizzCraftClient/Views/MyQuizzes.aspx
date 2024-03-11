<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="MyQuizzes.aspx.cs" Inherits="QuizzCraftClient.Views.MyQuizzes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <link rel="stylesheet" type="text/css" href="Style.css" />
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>My Quizzes</h1>


    <asp:Button ID="btnAddQuiz" runat="server" Text="Add Quiz" CssClass="addButton" PostBackUrl="AddQuiz.aspx"/>
    <br>
    <br>
    <div class="container">
    <div class="row">
        <div class="col-md-9">
                <asp:GridView ID="GridViewQuizzes" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="QuizId" HeaderText="Quiz Id" />
            <asp:BoundField DataField="Title" HeaderText="Quiz Title" />
            <asp:BoundField DataField="Subject" HeaderText="Quiz Subject" />

            <asp:TemplateField HeaderText="Update Actions">
                <ItemTemplate>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" CssClass="updateButton" CommandName="UpdateRow" OnClick="btnUpdate_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Delete Actions">
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" CssClass="deleteButton" CommandName="DeleteRow" OnClick="btnDelete_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Show Question">
                <ItemTemplate>
                    <asp:Button ID="btnShowQuestion" runat="server" Text="Show" CssClass="showButton" CommandName="" OnClick="btnShowQuestion_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Add Question">
                <ItemTemplate>
                    <asp:Button ID="btnAddQuestion" runat="server" Text="Add" CssClass="addButton" CommandName="" OnClick="btnAddQuestion_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>
    </asp:GridView>
         </div>

        <div class="col">

        </div>
    </div>
</div>


</asp:Content>
