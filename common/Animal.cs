/*
 * Animal.cs
 *   作成	Rhizome
 *------------------------------------------------------------
 * Copyright(c) Rhizome Inc. All Rights Reserved.
 */

using System;

namespace common
{
    /**
     * 動物の情報や行動を持ったクラスです
     *
     */
    public class Animal
    {
        /** 名前 */
        private string name;

        /**
         * 行動：走る
         */
        public void Run()
        {
            Console.WriteLine(this.name + "は走りました。");
        }

        /**
         * 行動：食べる
         */
        public void Eat()
        {
            Console.WriteLine(this.name + "は食事をしました。");
        }

        /**
         * Setter
         * @param name
         */
        public void SetName(string name)
        {
            this.name = name;
        }

        /**
         * Getter
         * @return
         */
        public string GetName()
        {
            return this.name;
        }
    }
}