<!DOCTYPE html>

<html>
<head>
    <title>@ViewBag.Title</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />

    <script src="@Url.Content("~/Scripts/jquery-1.6.2.min.js")" type="text/javascript"></script>

    <script src="@Url.Content("~/Scripts/jquery.validate.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")" type="text/javascript"></script>

@Html.DevExpress().GetStyleSheets( 
    New StyleSheet With { .ExtensionSuite = ExtensionSuite.NavigationAndLayout }, 
    New StyleSheet With { .ExtensionSuite = ExtensionSuite.Editors }, 
    New StyleSheet With { .ExtensionSuite = ExtensionSuite.GridView }
    )
@Html.DevExpress().GetScripts( 
    New Script With { .ExtensionSuite = ExtensionSuite.NavigationAndLayout }, 
    New Script With { .ExtensionSuite = ExtensionSuite.GridView }, 
    New Script With { .ExtensionSuite = ExtensionSuite.Editors }
)
</head>

<body>
    @RenderBody()
</body>
</html>
