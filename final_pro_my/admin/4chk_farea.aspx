<%@ Page Language="C#" MasterPageFile="~/admin/admin_Master.master" AutoEventWireup="true" CodeFile="4chk_farea.aspx.cs" Inherits="admin_4chk_farea" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="border-right: maroon thick groove; border-top: maroon thick groove;
        border-left: maroon thick groove; width: 100%; border-bottom: maroon thick groove">
        <tr>
            <td colspan="2" style="background-color: white; text-align: center">
            </td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white; text-align: center">
                <span style="color: black; font-family: Georgia"><strong>Chack Fare</strong></span></td>
        </tr>
        <tr>
            <td colspan="2" style="background-color: white; text-align: right">
                <span style="color: #ff3333"><strong><span style="color: black">.</span></strong></span></td>
        </tr>
        <tr>
            <td align="right" style="width: 25%; height: 24px">
                <strong><span style="color: #ff3333"></span>From:</strong></td>
            <td align="left" style="width: 70%; height: 24px">
                <asp:DropDownList ID="ddlfrom" runat="server" Style="position: static" Width="203px">
                    <asp:ListItem>Ahmedabad</asp:ListItem>
                    <asp:ListItem>Rajkot</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Puna</asp:ListItem>
                    <asp:ListItem>Jamnagar</asp:ListItem>
                    <asp:ListItem>Udaypur</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="width: 25%">
                <strong>To:</strong></td>
            <td align="left" style="width: 70%">
                <asp:DropDownList ID="ddlto" runat="server" Style="position: static" Width="201px">
                    <asp:ListItem>Ahmedabad</asp:ListItem>
                    <asp:ListItem>Ajmer</asp:ListItem>
                    <asp:ListItem>Anand</asp:ListItem>
                    <asp:ListItem>Baroda</asp:ListItem>
                    <asp:ListItem>Gandhidham</asp:ListItem>
                    <asp:ListItem>Gandhinagar</asp:ListItem>
                    <asp:ListItem>Jaipur</asp:ListItem>
                    <asp:ListItem>Jamnagar</asp:ListItem>
                    <asp:ListItem>Mumbai</asp:ListItem>
                    <asp:ListItem>Surat</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="width: 25%; height: 24px">
                <strong><span style="color: red"></span><span style="color: black">Date Of Journey:&nbsp;</span></strong></td>
            <td align="left" style="width: 70%; height: 24px">
                &nbsp;
                <asp:DropDownList ID="ddldate" runat="server" Style="position: static" Width="66px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                    <asp:ListItem>13</asp:ListItem>
                    <asp:ListItem>14</asp:ListItem>
                    <asp:ListItem>15</asp:ListItem>
                    <asp:ListItem>16</asp:ListItem>
                    <asp:ListItem>17</asp:ListItem>
                    <asp:ListItem>18</asp:ListItem>
                    <asp:ListItem>19</asp:ListItem>
                    <asp:ListItem>20</asp:ListItem>
                    <asp:ListItem>21</asp:ListItem>
                    <asp:ListItem>22</asp:ListItem>
                    <asp:ListItem>23</asp:ListItem>
                    <asp:ListItem>24</asp:ListItem>
                    <asp:ListItem>25</asp:ListItem>
                    <asp:ListItem>26</asp:ListItem>
                    <asp:ListItem>27</asp:ListItem>
                    <asp:ListItem>28</asp:ListItem>
                    <asp:ListItem>29</asp:ListItem>
                    <asp:ListItem>30</asp:ListItem>
                    <asp:ListItem>31</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlmonth" runat="server" Style="position: static" Width="66px">
                    <asp:ListItem>01</asp:ListItem>
                    <asp:ListItem>02</asp:ListItem>
                    <asp:ListItem>03</asp:ListItem>
                    <asp:ListItem>04</asp:ListItem>
                    <asp:ListItem>05</asp:ListItem>
                    <asp:ListItem>06</asp:ListItem>
                    <asp:ListItem>07</asp:ListItem>
                    <asp:ListItem>08</asp:ListItem>
                    <asp:ListItem>09</asp:ListItem>
                    <asp:ListItem>10</asp:ListItem>
                    <asp:ListItem>11</asp:ListItem>
                    <asp:ListItem>12</asp:ListItem>
                </asp:DropDownList>
                <asp:DropDownList ID="ddlyear" runat="server" Style="position: static" Width="66px">
                    <asp:ListItem>2009</asp:ListItem>
                    <asp:ListItem>2010</asp:ListItem>
                    <asp:ListItem>2011</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
        <tr>
            <td align="right" style="width: 25%">
                <strong>Bus Type : </strong>
            </td>
            <td align="left" style="width: 70%">
                <asp:DropDownList ID="ddlbustype" runat="server" Width="121px">
                    <asp:ListItem>AC</asp:ListItem>
                    <asp:ListItem>NonAC</asp:ListItem>
                    <asp:ListItem>Two By Two</asp:ListItem>
                    <asp:ListItem>Three By Two</asp:ListItem>
                </asp:DropDownList></td>
        </tr>
    <tr>
        <td align="left" colspan="2" style="height: 20px">
        </td>
    </tr>
        <tr>
            <td align="left" colspan="2" style="height: 20px">
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                &nbsp; &nbsp; &nbsp; &nbsp;
                <asp:Button ID="btnchkfare" runat="server" BackColor="Gray" Font-Bold="True" ForeColor="WhiteSmoke"
                    Height="23px" Style="color: #000000; background-color: skyblue" Text="CHACK FARE"
                    Width="135px" /></td>
        </tr>
    </table>
</asp:Content>

