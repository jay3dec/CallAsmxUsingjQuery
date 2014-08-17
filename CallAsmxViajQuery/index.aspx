<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CallAsmxViajQuery.index" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-2.1.1.js" type="text/javascript"></script>
    <script type="text/javascript" language="javascript">
        $(function () {
            $('#btnCallService').click(function () {
                $.ajax({
                    type: 'POST',
                    url: 'HelloService.asmx/GetEmployeeDetail',
                    dataType: 'json',
                    contentType: 'application/json; charset=utf-8',
                    success: function (response) {
                        $('#lblData').html(JSON.stringify(response));
                    },
                    error: function (error) {
                        console.log(error);
                    }
                });
            });
        });
    </script>
</head>
<body>
  <input type="button" id="btnCallService" value="GetEmployeeDetail" />
  <label id="lblData"></label>
</body>
</html>
