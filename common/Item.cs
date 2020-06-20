/*
 * Itm.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace common
{
    /**
     * 装備品オブジェクト
     * @author rhizome
     *
     */
    public class Item
    {
        /** アイテム名 */
        private string name;

        /** 追加ダメージ量 */
        private int additionalDamage;

        /**
         * 装備品の初期値を設定するコンストラクタ
         * @param name	装備品名
         * @param additionalDamage	追加ダメージ
         */
        public Item(string name, int additionalDamage)
        {
            this.name = name;
            this.additionalDamage = additionalDamage;
        }

        /**
         * アイテム名を取得します
         * @return アイテム名
         */
        public string GetName()
        {
            return name;
        }

        /**
         * アイテム名を設定します
         * @param name	設定したいアイテム名
         */
        public void SetName(string name)
        {
            this.name = name;
        }

        /**
         * 追加ダメージを取得します
         * @return	追加ダメージ
         */
        public int GetAdditionalDamage()
        {
            return additionalDamage;
        }

        /**
         * 追加ダメージを設定します
         * @param additionalDamage	設定したい追加ダメージ
         */
        public void SetAdditionalDamage(int additionalDamage)
        {
            this.additionalDamage = additionalDamage;
        }
    }
}
