using Dapper;
using MyHomePage.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MyHomePage.Repositories
{
    /// <summary>
    /// 基底リポジトリ
    /// </summary>
    public class RepositoryBase : IDisposable
    {
        /// <summary>
        /// 接続情報
        /// </summary>
        protected readonly SqlConnection Con;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="conStr"></param>
        public RepositoryBase(string conStr)
        {
            this.Con = new SqlConnection(conStr);
            this.Con.Open();
        }

        /// <summary>
        /// 記事情報取得
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Article> GetArticles()
        {
            string sql = $@"SELECT * FROM [C:\USERS\RAINA\SOURCE\REPOS\MYHOMEPAGE\MYHOMEPAGE\APP_DATA\DATABASE.MDF].[dbo].[ARTICLE] ORDER BY Date DESC";
            return this.Con.Query<Article>(sql);
        }

        /// <summary>
        /// 記事情報取得
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Article GetArticle(string id)
        {
            string sql = $@"SELECT * FROM [C:\USERS\RAINA\SOURCE\REPOS\MYHOMEPAGE\MYHOMEPAGE\APP_DATA\DATABASE.MDF].[dbo].[ARTICLE] WHERE ID = @Id";
            return this.Con.QueryFirstOrDefault<Article>(sql, new { id = id });
        }

        #region IDisposableの解放
        private bool disposedValue;

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: マネージド状態を破棄します (マネージド オブジェクト)
                    this.Con.Dispose();
                }

                // TODO: アンマネージド リソース (アンマネージド オブジェクト) を解放し、ファイナライザーをオーバーライドします
                // TODO: 大きなフィールドを null に設定します
                disposedValue = true;
            }
        }

        // // TODO: 'Dispose(bool disposing)' にアンマネージド リソースを解放するコードが含まれる場合にのみ、ファイナライザーをオーバーライドします
        // ~RepositoryBase()
        // {
        //     // このコードを変更しないでください。クリーンアップ コードを 'Dispose(bool disposing)' メソッドに記述します
        //     Dispose(disposing: false);
        // }

        void IDisposable.Dispose()
        {
            // このコードを変更しないでください。クリーンアップ コードを 'Dispose(bool disposing)' メソッドに記述します
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }

    #endregion
}