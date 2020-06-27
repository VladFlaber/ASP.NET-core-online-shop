
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text.Encodings.Web;
using System.Web;


namespace Shop.Infrastructure.Helpers
{
    public static class ProductRenderHelper
    {
        private static TagBuilder CreateImage(string src)
        {
            TagBuilder ImgDiv = new TagBuilder("div");
            ImgDiv.AddCssClass("ImgDiv");
            TagBuilder img = new TagBuilder("img");
            string ProductImage = string.IsNullOrWhiteSpace(src)
                ? "../Images/NoImage.jpg"
                : src;
            img.MergeAttribute("src", ProductImage);
            //img.MergeAttribute("alt", "none");
            img.MergeAttribute("width", "100%");
            img.MergeAttribute("height", "200px");
            ImgDiv.InnerHtml.AppendHtml(img);
            return ImgDiv;
        }
        private static TagBuilder CreateParagraph(string text, string className)
        {
            TagBuilder p = new TagBuilder("p");
            p.InnerHtml.Append(text);
            if (!string.IsNullOrWhiteSpace(className))
                p.AddCssClass(className);
            return p;
        }
        private static TagBuilder ProductRatingRender(int rating)
        {
            TagBuilder rate = new TagBuilder("div");

            int stars = 0;
            for (int i = 0; i < rating; i++)
            {
                TagBuilder text = new TagBuilder("i");
                text.AddCssClass("fa fa-star");
                text.Attributes["color"] = "red";
                rate.InnerHtml.AppendHtml(text);
                stars++;
            }
            if (stars < 10)
            {
                for (int i = stars; i < 10; i++)
                {
                    TagBuilder text = new TagBuilder("i");
                    text.AddCssClass("fa fa-star-of-life");
                    text.Attributes["color"] = "yellow";

                    rate.InnerHtml.AppendHtml(text);
                }
            }


            return rate;
        }
        public static HtmlString GetProduct(this IHtmlHelper html, ProductViewModel model)
        {
            TagBuilder div = new TagBuilder("div");
            div.AddCssClass("divProduct");
            TagBuilder divContent = new TagBuilder("div");

            TagBuilder anchor = new TagBuilder("a");
            anchor.MergeAttribute("href", "/home/ProductDetails/" + model.Product.Id);
              div.InnerHtml.AppendHtml(CreateImage(model.FrontImage));
           divContent.InnerHtml.AppendHtml(CreateParagraph(model.Category, null));
           divContent.InnerHtml.AppendHtml(CreateParagraph(model.Product.Name, null));
           divContent.InnerHtml.AppendHtml(CreateParagraph(model.ManufacturerName, null));
           divContent.InnerHtml.AppendHtml(CreateParagraph(model.Product.Price.ToString(), null));
           divContent.InnerHtml.AppendHtml(ProductRatingRender(model.Product.Rating));
           divContent.InnerHtml.AppendHtml(CreateParagraph(model.CommentsCount.ToString(), "fas fa-comment"));
            div.InnerHtml.AppendHtml(divContent);
            div.InnerHtml.AppendHtml(anchor);
            var writer = new System.IO.StringWriter();
            div.WriteTo(writer, HtmlEncoder.Default);
            return new HtmlString(writer.ToString());

        }
    }
}