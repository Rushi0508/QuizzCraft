<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="UpdateQuiz.aspx.cs" Inherits="QuizzCraftClient.Views.UpdateQuiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    
        <div class="container mt-2">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                </center>
                            </div>
                        </div>

                        <h3 class="text-center">Add Quiz Details</h3>
                        <center>

                            <asp:Label ID="lblUpdateSuccessfull" runat="server" ForeColor="Green"></asp:Label>

                        </center>

                        <hr>

                        <div class="mb-3">

                            <asp:Label ID="TitleLabel" runat="server" AssociatedControlID="TitleTextBox" Text="Quiz Title:" />&nbsp;<asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="TitleTextBox" ErrorMessage="Quiz Title is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<br />
                            <asp:TextBox ID="TitleTextBox" CssClass="form-control" runat="server" placeholder="Quiz Title" />
                        </div>


                        <div class="mb-3">

                            <asp:Label ID="SubjectLabel" runat="server" AssociatedControlID="SubjectTextBox" Text="Quiz Subject:" />&nbsp;<asp:RequiredFieldValidator ID="rfvSubject" runat="server" ControlToValidate="SubjectTextBox" ErrorMessage="Quiz Subject is required" ForeColor="Red"></asp:RequiredFieldValidator>
                            &nbsp;<br />
                            <asp:TextBox ID="SubjectTextBox" CssClass="form-control" placeholder="Quiz Subject" runat="server" />
                        </div>

                        <div class="d-grid gap-2">

                            <asp:Button class="btn btn-warning btn-block" ID="CreateButton" runat="server" Text="Update" OnClick="UpdateQuizButton_Click" /><br />

                        </div>


                    </div>
                </div>

            </div>
        </div>
    </div>



</asp:Content>
