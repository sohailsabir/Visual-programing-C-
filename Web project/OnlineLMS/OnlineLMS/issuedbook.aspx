<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="issuedbook.aspx.cs" Inherits="OnlineLMS.issuedbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div class="container-fluid">
        <div class="row">
            <div class="col-md-5">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                           
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3>Book Issuing</h3>
                                      
                                    </center>
                                </div>
                            </div>
                             <div class="row">
                                <div class="col">
                                    <center>
                                         <img width="150px" src="imgs/issueBook.gif" />
                                    </center>
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <hr />
                                </div>
                            </div>
                           
                            <div class="row">
                                <div class="col-md-6">
                                     <label >Resgistration No</label>
                                    <div class="form-group">
                                        
                                          <div class="input-group">
                                                <asp:TextBox CssClass="form-control" ID="TextBox3" placeholder="Registration No" runat="server"></asp:TextBox>
                                                 <asp:Button  class="btn btn-primary " ID="Button1" runat="server" Text="GO"   />
                                           </div>
                                        
                                    </div>
                                        </div>
                                <div class="col-md-6">
                                    <label  >Book Name</label>
                                    <div class="form-group">
                                        <asp:DropDownList CssClass="form-control" ID="DropDownList1"  runat="server"></asp:DropDownList>

                                    </div>
                                </div>
                               
                        </div>
                            <div class="row">
                                <div class="col-md-12">
                                     <label >Member Name</label>
                                    <div class="form-group">
                                        
                                          
                                                <asp:TextBox CssClass="form-control" ID="TextBox1" placeholder="Member Name" runat="server" ReadOnly="True"></asp:TextBox>
                                        
                                           
                                        
                                    </div>
                                        </div>
                               
                               
                        </div>
                            <div class="row">
                                <div class="col-md-6">
                                     <label >Start Date</label>
                                    <div class="form-group">
                                        
                                          
                                                <asp:TextBox CssClass="form-control" ID="TextBox2"  runat="server" TextMode="Date"></asp:TextBox>
                                        
                                           
                                        
                                    </div>
                                        </div>
                                 <div class="col-md-6">
                                     <label >End Date</label>
                                    <div class="form-group">
                                        
                                          
                                                <asp:TextBox CssClass="form-control" ID="TextBox4"  runat="server" TextMode="Date"></asp:TextBox>
                                        
                                           
                                        
                                    </div>
                                        </div>
                               
                               
                        </div>
                            <br />
                            
                             <div class="row">
                                <div class="col-6">
                                    <div class="d-grid gap-2">
                                    <asp:Button class="btn btn-lg btn-primary" ID="Button2"  runat="server" Text="Issue" />
                                        </div>
                                </div>
                                 <div class="col-6">
                                     <div class="d-grid gap-2">
                                    <asp:Button class="btn btn-lg btn-success" ID="Button3"  runat="server" Text="Return" />
                                         </div>
                                </div>
                                
                             </div>

                            </div>
                           
                           
                    
                        </div>
                     
                        </div>
                
               <a href="homepage.aspx">Back to Home Page</a>
                    </div>
                
            <div class="col-md-7">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                           
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3>Issued Book List</h3>
                                        
                                    </center>
                                </div>
                            </div>
                            
                            <div class="row">
                                <div class="col-md-12">
                                    <hr />
                                </div>
                            </div>
                            <div class="row">
                                <div class="col-md-12">
                                    <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField DataField="stuid" HeaderText="stuid" SortExpression="stuid" />
                                            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                                            <asp:BoundField DataField="bid" HeaderText="bid" SortExpression="bid" />
                                            <asp:BoundField DataField="issuedate" HeaderText="issuedate" SortExpression="issuedate" />
                                        </Columns>
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Library_Management_SystemConnectionString %>" SelectCommand="SELECT [stuid], [id], [bid], [issuedate] FROM [IRBook]"></asp:SqlDataSource>
                                </div>
                            </div>
                           
                           
                        
                    
                        </div>
                     
                        </div>
                
             
                    </div>
                </div>
         </div>
         </div>
</asp:Content>
