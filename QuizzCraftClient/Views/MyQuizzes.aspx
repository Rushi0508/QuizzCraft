<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="MyQuizzes.aspx.cs" Inherits="QuizzCraftClient.Views.MyQuizzes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

      <link rel="stylesheet" type="text/css" href="Style.css" />
        <style>
        /* CSS styles */
        body {
            font-family: Arial, sans-serif;
            margin: 0;
            padding: 0;
        }

        h1 {
            text-align: center;
            margin-top: 20px;
        }

        .container {
            width: 80%;
            margin: 20px auto;
        }

        .row {
            display: flex;
            flex-wrap: wrap;
            justify-content: space-between;
        }

        .col-md-9 {
            width: 70%;
        }

        .col {
            width: 25%;
        }

        table {
            width: 100%;
            border-collapse: collapse;
            border-spacing: 0;
        }

        th, td {
            padding: 10px;
            text-align: left;
            border-bottom: 1px solid #ddd;
        }

        th {
            background-color: #f2f2f2;
        }

        .btn-attempt {
            background-color: #007bff;
            color: #fff;
            border: none;
            padding: 8px 16px;
            text-align: center;
            text-decoration: none;
            display: inline-block;
            font-size: 14px;
            border-radius: 4px;
            cursor: pointer;
        }

        .btn-attempt:hover {
            background-color: #0056b3;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>My Quizzes</h1>


    <div class="container">
    <asp:Button ID="btnAddQuiz" runat="server" Text="Add Quiz" class="btn btn-success" PostBackUrl="AddQuiz.aspx"/>
    <br>
    <br>

    <div class="row">
        <div class="col-md-9">
                <asp:GridView ID="GridViewQuizzes" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="Title" HeaderText="Quiz Title" />
            <asp:BoundField DataField="Subject" HeaderText="Quiz Subject" />

            <asp:TemplateField HeaderText="Update Quiz">
                <ItemTemplate>
                    <asp:Button ID="btnUpdate" runat="server" Text="Update" class="btn btn-warning" CommandName="UpdateRow" OnClick="btnUpdate_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Delete Quiz">
                <ItemTemplate>
                    <asp:Button ID="btnDelete" runat="server" Text="Delete" class="btn btn-danger" CommandName="DeleteRow" OnClick="btnDelete_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Show Questions">
                <ItemTemplate>
                    <asp:Button ID="btnShowQuestion" runat="server" Text="Show" class="btn btn-info" CommandName="" OnClick="btnShowQuestion_Click" CommandArgument='<%# Eval("QuizId") %>' />
                </ItemTemplate>
            </asp:TemplateField>

            <asp:TemplateField HeaderText="Add Question">
                <ItemTemplate>
                    <asp:Button ID="btnAddQuestion" runat="server" Text="Add" class="btn btn-success" CommandName="" OnClick="btnAddQuestion_Click" CommandArgument='<%# Eval("QuizId") %>' />
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
