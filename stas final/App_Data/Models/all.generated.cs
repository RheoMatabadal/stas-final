using  System;
using  System.Collections.Generic;
using  System.Linq.Expressions;
using  System.Web;
using  Umbraco.Core.Models;
using  Umbraco.Core.Models.PublishedContent;
using  Umbraco.Web;
using  Umbraco.ModelsBuilder;
using  Umbraco.ModelsBuilder.Umbraco;
[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "741383f303ad874a")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.4")]


// FILE: models.generated.cs

//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.10.102
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------















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

	/// <summary>About</summary>
	[PublishedContentModel("about")]
	public partial class About : PublishedContentModel, IBanner
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "about";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public About(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerFoto")]
		public IPublishedContent BannerFoto
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerFoto(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBalk")]
		public string WitteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBalk(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteBalk")]
		public string ZwarteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteBalk(this); }
		}
	}

	/// <summary>Corporate Identities</summary>
	[PublishedContentModel("corporateIdentities")]
	public partial class CorporateIdentities : PublishedContentModel, IBanner
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
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerFoto")]
		public IPublishedContent BannerFoto
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerFoto(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBalk")]
		public string WitteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBalk(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteBalk")]
		public string ZwarteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteBalk(this); }
		}
	}

	/// <summary>Graphic Design</summary>
	[PublishedContentModel("graphicDesign")]
	public partial class GraphicDesign : PublishedContentModel, IBanner
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
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerFoto")]
		public IPublishedContent BannerFoto
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerFoto(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBalk")]
		public string WitteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBalk(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteBalk")]
		public string ZwarteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteBalk(this); }
		}
	}

	/// <summary>events</summary>
	[PublishedContentModel("events")]
	public partial class Events : PublishedContentModel, IBanner
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
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerFoto")]
		public IPublishedContent BannerFoto
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetBannerFoto(this); }
		}

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBalk")]
		public string WitteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetWitteBalk(this); }
		}

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteBalk")]
		public string ZwarteBalk
		{
			get { return Umbraco.Web.PublishedContentModels.Banner.GetZwarteBalk(this); }
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
		/// <summary>Banner Foto</summary>
		IPublishedContent BannerFoto { get; }

		/// <summary>witte balk</summary>
		string WitteBalk { get; }

		/// <summary>zwarte Balk</summary>
		string ZwarteBalk { get; }
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
		/// Banner Foto
		///</summary>
		[ImplementPropertyType("bannerFoto")]
		public IPublishedContent BannerFoto
		{
			get { return GetBannerFoto(this); }
		}

		/// <summary>Static getter for Banner Foto</summary>
		public static IPublishedContent GetBannerFoto(IBanner that) { return that.GetPropertyValue<IPublishedContent>("bannerFoto"); }

		///<summary>
		/// witte balk
		///</summary>
		[ImplementPropertyType("witteBalk")]
		public string WitteBalk
		{
			get { return GetWitteBalk(this); }
		}

		/// <summary>Static getter for witte balk</summary>
		public static string GetWitteBalk(IBanner that) { return that.GetPropertyValue<string>("witteBalk"); }

		///<summary>
		/// zwarte Balk
		///</summary>
		[ImplementPropertyType("zwarteBalk")]
		public string ZwarteBalk
		{
			get { return GetZwarteBalk(this); }
		}

		/// <summary>Static getter for zwarte Balk</summary>
		public static string GetZwarteBalk(IBanner that) { return that.GetPropertyValue<string>("zwarteBalk"); }
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



// EOF
