//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "1dfa8507695c040b")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel, IArtist
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// About Text
		///</summary>
		[ImplementPropertyType("aboutText")]
		public IHtmlString AboutText
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutText"); }
		}

		///<summary>
		/// About Title
		///</summary>
		[ImplementPropertyType("aboutTitle")]
		public string AboutTitle
		{
			get { return this.GetPropertyValue<string>("aboutTitle"); }
		}

		///<summary>
		/// Contact Email
		///</summary>
		[ImplementPropertyType("contactEmail")]
		public string ContactEmail
		{
			get { return this.GetPropertyValue<string>("contactEmail"); }
		}

		///<summary>
		/// contact Title
		///</summary>
		[ImplementPropertyType("contactTitle")]
		public string ContactTitle
		{
			get { return this.GetPropertyValue<string>("contactTitle"); }
		}

		///<summary>
		/// Home Banner Text
		///</summary>
		[ImplementPropertyType("homeBannerText")]
		public string HomeBannerText
		{
			get { return this.GetPropertyValue<string>("homeBannerText"); }
		}

		///<summary>
		/// Home Landing Image
		///</summary>
		[ImplementPropertyType("homeLandingImage")]
		public IPublishedContent HomeLandingImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("homeLandingImage"); }
		}

		///<summary>
		/// Artist Image
		///</summary>
		[ImplementPropertyType("artistImage")]
		public IPublishedContent ArtistImage
		{
			get { return Umbraco.Web.PublishedContentModels.Artist.GetArtistImage(this); }
		}
	}

	/// <summary>About Us</summary>
	[PublishedContentModel("aboutUs")]
	public partial class AboutUs : PublishedContentModel, IArtist, IBanner, ICTA, ITextSection
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "aboutUs";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AboutUs(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AboutUs, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// about Text Col 1
		///</summary>
		[ImplementPropertyType("aboutTextCol1")]
		public IHtmlString AboutTextCol1
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutTextCol1"); }
		}

		///<summary>
		/// About Text Col 2
		///</summary>
		[ImplementPropertyType("aboutTextCol2")]
		public IHtmlString AboutTextCol2
		{
			get { return this.GetPropertyValue<IHtmlString>("aboutTextCol2"); }
		}

		///<summary>
		/// subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}

		///<summary>
		/// Artist Image
		///</summary>
		[ImplementPropertyType("artistImage")]
		public IPublishedContent ArtistImage
		{
			get { return Umbraco.Web.PublishedContentModels.Artist.GetArtistImage(this); }
		}

		///<summary>
		/// Banner Author
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerImage(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBox(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteText(this); }
		}

		///<summary>
		/// CTAImage
		///</summary>
		[ImplementPropertyType("ctaImage")]
		public IPublishedContent CtaImage
		{
			get { return Umbraco.Web.PublishedContentModels.CTA.GetCtaImage(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.TextSection.GetTitleText(this); }
		}
	}

	/// <summary>Corporate Identities</summary>
	[PublishedContentModel("corporateIdentities")]
	public partial class CorporateIdentities : PublishedContentModel, IArtist, IBanner, ITextSection
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "corporateIdentities";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CorporateIdentities(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CorporateIdentities, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// BlackBox Text
		///</summary>
		[ImplementPropertyType("blackBoxText")]
		public IHtmlString BlackBoxText
		{
			get { return this.GetPropertyValue<IHtmlString>("blackBoxText"); }
		}

		///<summary>
		/// BlackBox Title
		///</summary>
		[ImplementPropertyType("blackBoxTitle")]
		public string BlackBoxTitle
		{
			get { return this.GetPropertyValue<string>("blackBoxTitle"); }
		}

		///<summary>
		/// subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public string Subtitle
		{
			get { return this.GetPropertyValue<string>("subtitle"); }
		}

		///<summary>
		/// subtitle2
		///</summary>
		[ImplementPropertyType("subtitle2")]
		public string Subtitle2
		{
			get { return this.GetPropertyValue<string>("subtitle2"); }
		}

		///<summary>
		/// subtitle3
		///</summary>
		[ImplementPropertyType("subtitle3")]
		public string Subtitle3
		{
			get { return this.GetPropertyValue<string>("subtitle3"); }
		}

		///<summary>
		/// text
		///</summary>
		[ImplementPropertyType("text")]
		public IHtmlString Text
		{
			get { return this.GetPropertyValue<IHtmlString>("text"); }
		}

		///<summary>
		/// text2
		///</summary>
		[ImplementPropertyType("text2")]
		public IHtmlString Text2
		{
			get { return this.GetPropertyValue<IHtmlString>("text2"); }
		}

		///<summary>
		/// text3
		///</summary>
		[ImplementPropertyType("text3")]
		public IHtmlString Text3
		{
			get { return this.GetPropertyValue<IHtmlString>("text3"); }
		}

		///<summary>
		/// title2
		///</summary>
		[ImplementPropertyType("title2")]
		public string Title2
		{
			get { return this.GetPropertyValue<string>("title2"); }
		}

		///<summary>
		/// title3
		///</summary>
		[ImplementPropertyType("title3")]
		public string Title3
		{
			get { return this.GetPropertyValue<string>("title3"); }
		}

		///<summary>
		/// Artist Image
		///</summary>
		[ImplementPropertyType("artistImage")]
		public IPublishedContent ArtistImage
		{
			get { return Umbraco.Web.PublishedContentModels.Artist.GetArtistImage(this); }
		}

		///<summary>
		/// Banner Author
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerImage(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBox(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteText(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.TextSection.GetTitleText(this); }
		}
	}

	/// <summary>Graphic Design</summary>
	[PublishedContentModel("graphicDesign")]
	public partial class GraphicDesign : PublishedContentModel, IArtist, IBanner, ICTA, ITextSection
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "graphicDesign";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public GraphicDesign(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<GraphicDesign, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// adobeCC
		///</summary>
		[ImplementPropertyType("adobeCC")]
		public string AdobeCC
		{
			get { return this.GetPropertyValue<string>("adobeCC"); }
		}

		///<summary>
		/// DTP
		///</summary>
		[ImplementPropertyType("dTP")]
		public string DTP
		{
			get { return this.GetPropertyValue<string>("dTP"); }
		}

		///<summary>
		/// graphicColLinks
		///</summary>
		[ImplementPropertyType("graphicColLinks")]
		public IHtmlString GraphicColLinks
		{
			get { return this.GetPropertyValue<IHtmlString>("graphicColLinks"); }
		}

		///<summary>
		/// graphicColRechts
		///</summary>
		[ImplementPropertyType("graphicColRechts")]
		public IHtmlString GraphicColRechts
		{
			get { return this.GetPropertyValue<IHtmlString>("graphicColRechts"); }
		}

		///<summary>
		/// ontwerp
		///</summary>
		[ImplementPropertyType("ontwerp")]
		public string Ontwerp
		{
			get { return this.GetPropertyValue<string>("ontwerp"); }
		}

		///<summary>
		/// webdesign
		///</summary>
		[ImplementPropertyType("webdesign")]
		public string Webdesign
		{
			get { return this.GetPropertyValue<string>("webdesign"); }
		}

		///<summary>
		/// Artist Image
		///</summary>
		[ImplementPropertyType("artistImage")]
		public IPublishedContent ArtistImage
		{
			get { return Umbraco.Web.PublishedContentModels.Artist.GetArtistImage(this); }
		}

		///<summary>
		/// Banner Author
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerImage(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBox(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteText(this); }
		}

		///<summary>
		/// CTAImage
		///</summary>
		[ImplementPropertyType("ctaImage")]
		public IPublishedContent CtaImage
		{
			get { return Umbraco.Web.PublishedContentModels.CTA.GetCtaImage(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.TextSection.GetTitleText(this); }
		}
	}

	/// <summary>events</summary>
	[PublishedContentModel("events")]
	public partial class Events : PublishedContentModel, IArtist, IBanner, ITextSection
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "events";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Events(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Events, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// conceptText
		///</summary>
		[ImplementPropertyType("conceptText")]
		public IHtmlString ConceptText
		{
			get { return this.GetPropertyValue<IHtmlString>("conceptText"); }
		}

		///<summary>
		/// conceptTitle
		///</summary>
		[ImplementPropertyType("conceptTitle")]
		public string ConceptTitle
		{
			get { return this.GetPropertyValue<string>("conceptTitle"); }
		}

		///<summary>
		/// logistiekText
		///</summary>
		[ImplementPropertyType("logistiekText")]
		public IHtmlString LogistiekText
		{
			get { return this.GetPropertyValue<IHtmlString>("logistiekText"); }
		}

		///<summary>
		/// logistiekTitle
		///</summary>
		[ImplementPropertyType("logistiekTitle")]
		public string LogistiekTitle
		{
			get { return this.GetPropertyValue<string>("logistiekTitle"); }
		}

		///<summary>
		/// PersText
		///</summary>
		[ImplementPropertyType("persText")]
		public IHtmlString PersText
		{
			get { return this.GetPropertyValue<IHtmlString>("persText"); }
		}

		///<summary>
		/// PersTitle
		///</summary>
		[ImplementPropertyType("persTitle")]
		public string PersTitle
		{
			get { return this.GetPropertyValue<string>("persTitle"); }
		}

		///<summary>
		/// subtitle
		///</summary>
		[ImplementPropertyType("subtitle")]
		public IHtmlString Subtitle
		{
			get { return this.GetPropertyValue<IHtmlString>("subtitle"); }
		}

		///<summary>
		/// Artist Image
		///</summary>
		[ImplementPropertyType("artistImage")]
		public IPublishedContent ArtistImage
		{
			get { return Umbraco.Web.PublishedContentModels.Artist.GetArtistImage(this); }
		}

		///<summary>
		/// Banner Author
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerAuthor(this); }
		}

		///<summary>
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerImage(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBox(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteText(this); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return Umbraco.Web.PublishedContentModels.TextSection.GetTitleText(this); }
		}
	}

	/// <summary>portfolio</summary>
	[PublishedContentModel("portfolio")]
	public partial class Portfolio : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "portfolio";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Portfolio(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Portfolio, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	// Mixin content Type 1069 with alias "banner"
	/// <summary>Banner</summary>
	public partial interface IBanner : IPublishedContent
	{
		/// <summary>Banner Author</summary>
		string BannerAuthor { get; }

		/// <summary>Banner Foto</summary>
		IPublishedContent BannerImage { get; }

		/// <summary>witte balk</summary>
		string WitteBox { get; }

		/// <summary>zwarte Balk</summary>
		string ZwarteText { get; }
	}

	/// <summary>Banner</summary>
	[PublishedContentModel("banner")]
	public partial class Banner : PublishedContentModel, IBanner
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "banner";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Banner(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Banner, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner Author
		///</summary>
		[ImplementPropertyType("bannerAuthor")]
		public string BannerAuthor
		{
			get { return GetBannerAuthor(this); }
		}

		/// <summary>Static getter for Banner Author</summary>
		public static string GetBannerAuthor(IBanner that) { return that.GetPropertyValue<string>("bannerAuthor"); }

		///<summary>
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerImage")]
		public IPublishedContent BannerImage
		{
			get { return GetBannerImage(this); }
		}

		/// <summary>Static getter for Banner Foto</summary>
		public static IPublishedContent GetBannerImage(IBanner that) { return that.GetPropertyValue<IPublishedContent>("bannerImage"); }

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBox")]
		public string WitteBox
		{
			get { return GetWitteBox(this); }
		}

		/// <summary>Static getter for witte balk</summary>
		public static string GetWitteBox(IBanner that) { return that.GetPropertyValue<string>("witteBox"); }

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteText")]
		public string ZwarteText
		{
			get { return GetZwarteText(this); }
		}

		/// <summary>Static getter for zwarte Balk</summary>
		public static string GetZwarteText(IBanner that) { return that.GetPropertyValue<string>("zwarteText"); }
	}

	// Mixin content Type 1073 with alias "artist"
	/// <summary>Artist</summary>
	public partial interface IArtist : IPublishedContent
	{
		/// <summary>Artist Image</summary>
		IPublishedContent ArtistImage { get; }
	}

	/// <summary>Artist</summary>
	[PublishedContentModel("artist")]
	public partial class Artist : PublishedContentModel, IArtist
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "artist";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Artist(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Artist, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Artist Image
		///</summary>
		[ImplementPropertyType("artistImage")]
		public IPublishedContent ArtistImage
		{
			get { return GetArtistImage(this); }
		}

		/// <summary>Static getter for Artist Image</summary>
		public static IPublishedContent GetArtistImage(IArtist that) { return that.GetPropertyValue<IPublishedContent>("artistImage"); }
	}

	// Mixin content Type 1077 with alias "cTA"
	/// <summary>CTA</summary>
	public partial interface ICTA : IPublishedContent
	{
		/// <summary>CTAImage</summary>
		IPublishedContent CtaImage { get; }
	}

	/// <summary>CTA</summary>
	[PublishedContentModel("cTA")]
	public partial class CTA : PublishedContentModel, ICTA
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "cTA";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public CTA(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<CTA, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// CTAImage
		///</summary>
		[ImplementPropertyType("ctaImage")]
		public IPublishedContent CtaImage
		{
			get { return GetCtaImage(this); }
		}

		/// <summary>Static getter for CTAImage</summary>
		public static IPublishedContent GetCtaImage(ICTA that) { return that.GetPropertyValue<IPublishedContent>("ctaImage"); }
	}

	// Mixin content Type 1079 with alias "textSection"
	/// <summary>text section</summary>
	public partial interface ITextSection : IPublishedContent
	{
		/// <summary>Title</summary>
		string TitleText { get; }
	}

	/// <summary>text section</summary>
	[PublishedContentModel("textSection")]
	public partial class TextSection : PublishedContentModel, ITextSection
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "textSection";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public TextSection(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<TextSection, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("titleText")]
		public string TitleText
		{
			get { return GetTitleText(this); }
		}

		/// <summary>Static getter for Title</summary>
		public static string GetTitleText(ITextSection that) { return that.GetPropertyValue<string>("titleText"); }
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
