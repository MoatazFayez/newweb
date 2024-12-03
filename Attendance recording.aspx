<%@ Page Title="" Language="C#" MasterPageFile="~/src/html/MasterPage.master" AutoEventWireup="true" CodeFile="Attendance recording.aspx.cs" Inherits="src_html_Attendance_recording" %>

<asp:Content ID="Content1" runat="server" 
    contentplaceholderid="ContentPlaceHolder1">
    <form id="form1" runat="server">
    <p>
        Scan QR Code</p>
    <p>
                                &nbsp;</p>
    <p>
    <body>

    <h1>Scan QR</h1>
    <div id="qrcode"></div>

    <script>
        // دالة لتوليد رمز QR بناءً على محتوى معين
        function generateQRCode(content) {
            var qrcode = new QRCode(document.getElementById("qrcode"), {
                text: content,
                width: 128,
                height: 128,
            });
        }

        // دالة لتوليد محتوى متغير كل دقيقة (على سبيل المثال باستخدام الوقت الحالي)
        function updateQRCode() {
            var currentTime = new Date().toISOString(); // أو يمكنك استخدام محتوى آخر
            document.getElementById("qrcode").innerHTML = ""; // مسح المحتوى الحالي
            generateQRCode(currentTime); // إنشاء QR جديد
        }

        // تحديث رمز QR كل دقيقة
        setInterval(updateQRCode, 60000); // 60000 ملي ثانية = دقيقة

        // أول مرة يتم فيها توليد QR عند تحميل الصفحة
        updateQRCode();
    </script>

</body>
        Select Sesion</p>
<%--    <p>
         <asp:TextBox ID="TextBox1"  class="form-control" placeholder="Student ID" runat="server"></asp:TextBox>
                             </p>--%>
  <asp:DropDownList ID="dblsearchsesion" 
        class="btn btn-primary w-100 py-8 fs-4 mb-4 rounded-2" runat="server" 
        onselectedindexchanged="DropDownList1_SelectedIndexChanged"></asp:DropDownList>
                             </p>
    <p>
        &nbsp;</p>
    <p>
                                <asp:Button ID="btnattendreccord" class="btn btn-primary w-100 py-8 fs-4 mb-4 rounded-2" runat="server" Text="Reccord" />
      </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    </form>
</asp:Content>




