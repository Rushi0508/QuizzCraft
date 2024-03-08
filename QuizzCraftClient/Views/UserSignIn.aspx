<%@ Page Title="" Language="C#" MasterPageFile="~/Views/QuizzCraft.Master" AutoEventWireup="true" CodeBehind="UserSignIn.aspx.cs" Inherits="QuizzCraftClient.Views.UserSignIn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container mt-5">
        <div class="row justify-content-center">
            <div class="col-md-6">
                <div class="card">
                    <div class="card-body">

                        <div class="row">
                            <div class="col">
                                <center>
                                    <img width="130px" src="/images/student.png" />
                                </center>
                            </div>
                        </div>

                        <h3 class="text-center">Student SignIn</h3>

                        <center>
                            <asp:Label ID="lblSignInError" runat="server" ForeColor="Red"></asp:Label>
                        </center>

                        <hr>
                        <div class="mb-3">
                            <label for="emailID" class="form-label">
                                Email ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <label for="username" class="form-label">
                                <asp:RequiredFieldValidator ID="rfvEmail" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email is required" ForeColor="Red"></asp:RequiredFieldValidator>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <asp:Label ID="lblEmailValidate" runat="server" ForeColor="Red"></asp:Label>
                            </label>
                            </label>
                            &nbsp;<asp:TextBox CssClass="form-control" ID="tbEmail" runat="server" placeholder="Email ID" TextMode="Email"></asp:TextBox>
                        </div>
                        <div class="mb-3">
                            <label for="password" class="form-label">
                                Password&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                            <label for="username" class="form-label">
                                <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="tbPassword" ErrorMessage="Password is required" ForeColor="Red"></asp:RequiredFieldValidator>
                                &nbsp;&nbsp;&nbsp;&nbsp;
                            <label for="emailID" class="form-label" id="lblPasswordValidate">
                                <asp:Label ID="lblPasswordValidate" runat="server" ForeColor="Red"></asp:Label>
                            </label>
                            </label>
                            </label>
                            &nbsp;<asp:TextBox CssClass="form-control" ID="tbPassword" runat="server" placeholder="Password" TextMode="Password"></asp:TextBox>
                        </div>
                        <hr>
                        <br>

                        <div class="d-grid gap-2">
                            <asp:Button class="btn btn-success btn-block" ID="btnLogin" runat="server" Text="SignIn" OnClick="SignInButton_Click" />

                            <a href="UserSignUp.aspx" class="btn btn-info btn-block">Sign Up</a>
                        </div>

                    </div>
                </div>

            </div>
        </div>
    </div>


</asp:Content>
