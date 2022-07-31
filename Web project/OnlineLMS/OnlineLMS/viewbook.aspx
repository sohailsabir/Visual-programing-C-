<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="viewbook.aspx.cs" Inherits="OnlineLMS.viewbook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript"> $(document).ready(function () { $(".table").prepend($("<thead></thead>").append($(this).find("tr:first"))).dataTable(); }); </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <a href="homepage.aspx">Back to Home Page</a><br />
&nbsp;
    <div class="container-fluid">
        <div class="row">
         <div class="col-md-12">
                <div class="card">
                    <div class="card-body">
                        <div class="card-body">
                           
                            <div class="row">
                                <div class="col">
                                    <center>
                                            <h3> Book List</h3>
                                        
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
                                    <asp:GridView class="table table-striped table-bordered" ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="bid" DataSourceID="SqlDataSource1">
                                        <Columns>
                                            <asp:BoundField DataField="bid" HeaderText="bid" InsertVisible="False" ReadOnly="True" SortExpression="bid" />
                                            <asp:BoundField DataField="bname" HeaderText="bname" SortExpression="bname" />
                                            <asp:BoundField DataField="bauthor" HeaderText="bauthor" SortExpression="bauthor" />
                                            <asp:BoundField DataField="bpubl" HeaderText="bpubl" SortExpression="bpubl" />
                                            <asp:BoundField DataField="bpdate" HeaderText="bpdate" SortExpression="bpdate" />
                                            <asp:BoundField DataField="bprice" HeaderText="bprice" SortExpression="bprice" />
                                            <asp:BoundField DataField="bquantity" HeaderText="bquantity" SortExpression="bquantity" />
                                        </Columns>
                                    </asp:GridView>
                                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Library_Management_SystemConnectionString %>" SelectCommand="SELECT * FROM [Books]"></asp:SqlDataSource>
                                </div>
                            </div>
                           
                           
                        
                    
                        </div>
                     
                        </div>
                
             
                    </div>
                </div>
         </div>
        </div>
         
</asp:Content>
