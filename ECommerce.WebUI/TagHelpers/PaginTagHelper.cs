﻿using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace ECommerce.WebUI.TagHelpers;
[HtmlTargetElement("product-list-pager")]
public class PaginTagHelper : TagHelper
{
	[HtmlAttributeName("page-size")]
	public int PageSize { get; set; }
	[HtmlAttributeName("page-count")]
	public int PageCount { get; set; }
	[HtmlAttributeName("current-category")]
	public int CurrentCateogry { get; set; }
	[HtmlAttributeName("current-page")]
	public int CurrentPage { get; set; }

	public override void Process(TagHelperContext context, TagHelperOutput output)
	{
		output.TagName = "section";
		var sb = new StringBuilder();
		sb.Append("<ul class='pagination'>");
		for (int i = 1; i <= PageCount; i++)
		{
			string activeClass = (i == CurrentPage) ? "page-item active" : "page-item";
			string url = $"/product/index?page={i}&categoryId={CurrentCateogry}";
			sb.AppendFormat("<li class='{0}'>", activeClass);
			sb.AppendFormat("<a class='page-link' href='{0}'>{1}</a>", url, i);
			sb.Append("</li>");
		}
		sb.Append("</ul>");
		output.Content.SetHtmlContent(sb.ToString());
	}
}
