<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="QuizzCraftClient.Views.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
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
    <div class="container">
        <div class="row">
            <div class="col-md-9">
                <h1>List Of All Quizzes</h1>
                <asp:GridView ID="GridViewQuizzes" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Title" HeaderText="Quiz Title" />
                        <asp:BoundField DataField="NumberOfQuestions" HeaderText="Number of Questions" />
                        <asp:BoundField DataField="Attendees" HeaderText="Number of times attending quiz" />
                        <asp:TemplateField HeaderText="Attempt Quiz">
                            <ItemTemplate>
                                <asp:Button ID="btnAttemptQuiz" runat="server" Text="Attempt" class="btn btn-success" CommandName="" OnClick="btnAttemptQuiz_Click" CommandArgument='<%# Eval("QuizId") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
            <div class="col-md-3">
                <h1>Topper's List</h1>
                <asp:GridView ID="GridViewStudents" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="Name" HeaderText="Name" />
                        <asp:BoundField DataField="Points" HeaderText="Points" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </div>
</asp:Content>
