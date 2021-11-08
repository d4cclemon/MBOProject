using System;

namespace MyHomePage.Models.Entities
{
    public class Article
    {
        /// <summary>
        /// ID
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// タイトル
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// 説明
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// 閲覧数
        /// </summary>
        public int ViewCount { get; }

        /// <summary>
        /// 投稿日時
        /// </summary>
        public DateTime Date { get; }

        /// <summary>
        /// 更新日時
        /// </summary>
        public DateTime UpDate { get; }
    }
}