using System.Collections.Generic;
/**
 * code by lsl1225 https://github.com/lsl1225/ffxiv_visland
 */
namespace visland.Workshop
{
    internal class Translate
    {
        public static List<Item> list =
        [
          new("海岛恢复药","Isleworks Potion"),
          new("开拓工房火药","Isleworks Firesand"),
          new("海岛座椅","Isleworks Wooden Chair"),
          new("开拓工房烤扇贝","Isleworks Grilled Clam"),
          new("海岛木制项链","Isleworks Necklace"),
          new("海岛珊瑚戒指","Isleworks Coral Ring"),
          new("海岛开面盔","Isleworks Barbut"),
          new("海岛石刃棒","Isleworks Macuahuitl"),
          new("开拓工房酸泡菜","Isleworks Sauerkraut"),
          new("开拓工房烤南瓜","Isleworks Baked Pumpkin"),
          new("海岛束腰衣","Isleworks Tunic"),
          new("海岛厨刀","Isleworks Culinary Knife"),
          new("海岛木刷","Isleworks Brush"),
          new("开拓工房水煮蛋","Isleworks Boiled Egg"),
          new("海岛骨拳","Isleworks Hora"),
          new("海岛兽牙耳坠","Isleworks Earrings"),
          new("开拓工房黄油","Isleworks Butter"),
          new("海岛砖块柜台","Isleworks Brick Counter"),
          new("绵羊铜像","Bronze Sheep"),
          new("开拓工房植物成长剂","Isleworks Growth Formula"),
          new("海岛石榴石刺剑","Isleworks Garnet Rapier"),
          new("海岛云杉圆盾","Isleworks Spruce Round Shield"),
          new("开拓工房鲨油","Isleworks Shark Oil"),
          new("海岛白银耳夹","Isleworks Silver Ear Cuffs"),
          new("开拓工房甜新薯","Isleworks Sweet Popoto"),
          new("开拓工房高山萝卜沙拉","Isleworks Parsnip Salad"),
          new("开拓工房焦糖","Isleworks Caramels"),
          new("海岛缎带","Isleworks Ribbon"),
          new("海岛绳索","Isleworks Rope"),
          new("海岛骑士帽","Isleworks Cavalier's Hat"),
          new("海岛角笛","Isleworks Horn"),
          new("海岛盐渍鳕鱼","Isleworks Salt Cod"),
          new("海岛墨鱼汁","Isleworks Squid Ink"),
          new("开拓工房仙药","Isleworks Essential Draught"),
          new("海岛莓果酱","Isleberry Jam"),
          new("海岛番茄酱","Isleworks Tomato Relish"),
          new("开拓工房洋葱汤","Isleworks Onion Soup"),
          new("开拓工房鱼派","Islefish Pie"),
          new("开拓工房玉米片","Isleworks Corn Flakes"),
          new("开拓工房腌小萝卜","Isleworks Pickled Radish"),
          new("海岛铁斧","Isleworks Iron Axe"),
          new("海岛石英戒指","Isleworks Quartz Ring"),
          new("开拓工房瓷罐","Isleworks Porcelain Vase"),
          new("开拓工房果蔬汁","Isleworks Vegetable Juice"),
          new("开拓工房南瓜布丁","Isleworks Pumpkin Pudding"),
          new("海岛绵羊地毯","Isleworks Sheepfluff Rug"),
          new("海岛园艺镰","Isleworks Garden Scythe"),
          new("海岛床","Isleworks Bed"),
          new("海岛鳞指套","Isleworks Scale Fingers"),
          new("海岛手杖","Isleworks Crook"),
          new("开拓工房珊瑚剑","Isleworks Coral Sword"),
          new("开拓工房椰汁","Isleworks Coconut Juice"),
          new("开拓工房蜂蜜","Isleworks Honey"),
          new("海岛蓝蛋白石","Isleworks Seashine Opal"),
          new("开拓工房干花","Isleworks Dried Flowers"),
          new("开拓工房辣椒粉","Isleworks Powdered Paprika"),
          new("开拓工房韭葱洋葱汤","Isleworks Cawl Cennin"),
          new("开拓工房无人面包","Isleworks Isloaf"),
          new("开拓工房新薯沙拉","Isleworks Popoto Salad"),
          new("开拓工房调味汁","Isleworks Dressing"),
          new("海岛暖炉","Isleworks Stove"),
          new("海岛提灯","Isleworks Lantern"),
          new("开拓工房泡碱","Isleworks Natron"),
          new("开拓工房五海杂烩汤","Isleworks Bouillabaisse"),
          new("开拓工房化石标本","Isleworks Fossil Display"),
          new("海岛浴缸","Isleworks Bathtub"),
          new("海岛眼镜","Isleworks Spectacles"),
          new("开拓工房隔热玻璃","Isleworks Cooling Glass"),
          new("开拓工房煎红花菜豆","Isleworks Runner Bean Saute"),
          new("开拓工房红菜汤","Isleworks Beet Soup"),
          new("海岛僧厥茄子镶肉","Isleworks Imam Bayildi"),
          new("开拓工房腌西葫芦","Isleworks Pickled Zucchini"),
          new("海岛黄铜餐盘","Isleworks Brass Serving Dish"),
          new("海岛砂轮机","Island Grinding Wheel"),
          new("海岛翠银环刃","Island Durium Tathlums"),
          new("开拓工房金发饰","Isleworks Gold Hairpin"),
          new("开拓者水晶像","Mammet of the Cycle Award"),
          new("海岛水果潘趣酒","Isleworks Fruit Punch"),
          new("海岛甜新薯挞","Isleworks Sweet Popoto Pie"),
          new("海岛风味拌细面","Isleworks Peperoncino"),
          new("海岛水牛豆沙拉","Isleworks Buffalo Bean Salad"),
        ];

        public static string? TranslateToEnglish(string? str)
        {
            if (str == null)
                return null;
            foreach (Item item in list)
            {
                if (item.Chinese == str)
                {
                    return item.English;
                }
            }
            return null;
        }
    }

    internal class Item(string cn, string en)
    {
        public string Chinese { get; set; } = cn;
        public string English { get; set; } = en;
    }
}
