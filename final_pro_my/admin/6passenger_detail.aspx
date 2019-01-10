<%@ Page Language="C#" MasterPageFile="~/admin/admin_Master.master" AutoEventWireup="true" CodeFile="6passenger_detail.aspx.cs" Inherits="admin_6passenger_detail" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

 <table style="border-right: maroon thick groove; border-top: maroon thick groove;
        border-left: maroon thick groove; width: 100%; border-bottom: maroon thick groove">
     <tr>
         <td colspan="2" style="background-color: white; text-align: center">
         </td>
     </tr>
                                        <tr>
                                            <td colspan="2" style="background-color: white; text-align: center">
                                                <span style="color: Black; font-family: Georgia"><strong>Passenger Details</strong></span></td>
                                        </tr>
                                        <tr>
                                            <td colspan="2" style="background-color: white; text-align: right">
                                                <span style="color: #ff3333"><strong><span style="color: black">.</span></strong></span></td>
                                        </tr>
     <tr>
         <td align="right" style="width: 25%; height: 24px">
             <strong>Bill No:</strong></td>
         <td align="left" style="width: 70%; height: 24px">
             <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1"
                 DataTextField="bill_no" DataValueField="bill_no">
             </asp:DropDownList><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>"
                 SelectCommand="SELECT [bill_no] FROM [passenger_master]"></asp:SqlDataSource>
         </td>
     </tr>
                                        <tr>
                                            <td align="right" style="width: 25%; height: 24px;">
                                                <strong><span style="color: #ff3333"></span>Full Name:</strong></td>
                                            <td align="left" style="width: 70%; height: 24px;">
                                                <asp:TextBox ID="txtname" runat="server" Width="313px" ReadOnly="True"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 25%">
                                                <strong>Age:</strong></td>
                                            <td align="left" style="width: 70%">
                                                <asp:TextBox ID="txtage" runat="server" Width="63px" ReadOnly="True"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 25%; height: 31px;">
                                                <strong><span style="color: black">Address:&nbsp;</span></strong></td>
                                            <td align="left" style="width: 70%; height: 31px; vertical-align: top; text-align: left;">
                                                <asp:TextBox ID="txtaddress" runat="server" TextMode="MultiLine" Width="313px" ReadOnly="True"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 25%">
                                                <strong>Phone No : </strong>
                                            </td>
                                            <td align="left" style="width: 70%">
                                                <asp:TextBox ID="txtphone" runat="server" Width="237px" ReadOnly="True"></asp:TextBox></td>
                                        </tr>
                                        <tr>
                                            <td align="right" style="width: 25%">
                                                <strong>Email ID:</strong></td>
                                            <td align="left" style="width: 70%">
                                                <asp:TextBox ID="txtmailid" runat="server" Width="395px" ReadOnly="True"></asp:TextBox></td>
                                        </tr>
     <tr>
         <td align="left" colspan="2" style="height: 8px">
         </td>
     </tr>
                                        <tr>
                                            <td align="left" colspan="2" style="height: 28px; vertical-align: top; text-align: center;">
                                               
                                                <asp:Button ID="btnpvs" runat="server" BackColor="Gray" Font-Bold="True"
                                                    ForeColor="WhiteSmoke" Height="23px" OnClick="btnpvs_Click" Style="color: #000000;
                                                    background-color: skyblue" Text="NEXT" Width="95px" />
                                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:Button ID="btnnext" runat="server" BackColor="Gray"
                                                    Font-Bold="True" ForeColor="WhiteSmoke" Height="23px" OnClick="btnnext_Click"
                                                    Style="color: #000000; background-color: skyblue" Text="PREVIOUS" Width="95px" />
                                                &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="Button1" runat="server" Text="FIRST"
                                                    Width="89px" />
                                                &nbsp; &nbsp;<asp:Button ID="Button2" runat="server" Text="LAST" Width="91px" />
                                                &nbsp; &nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="DELETE" Width="83px" />&nbsp;
                                            </td>
                                        </tr>
                                    </table>
</asp:Content>

