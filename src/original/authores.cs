using UnityEngine;

public class authores : MonoBehaviour
{
	public TextMesh text1;

	public TextMesh text2;

	public TextMesh text3;

	public TextMesh text4;

	private void Awake()
	{
		if (PlayerPrefs.GetInt("language") == 0)
		{
			text1.text = "<size=20><b> 中 国 ： 毛 的 遗 产</b></size>";
			text4.text = "<size=20>瓦 西 里 · 弗 拉 基 米 罗 维 奇 · 科 斯 特 列 夫\n马 克 西 姆·奥 列 格 维 奇·切 尔 诺 布 克</size>";
			text4.text += "\n<size=22> 协 助 开 发 人 员 ：\n马 克 西 姆· 科 斯 岑 / 伊 利 昂 · 索 拉 达 夫 / 弗 拉 基 米 尔 · 格 拉 达 索 夫\n\n 部 分 汉 化 文 本 基 于 前 辈 成 果 ， 在 此 向 他 们 表 示 感 谢 ！\n\n音 乐 创 作 ：\n尼 基 塔 · 米 什 凯 维 奇 (27.02.1993-22.01.2023) 愿 他 安 息\n 我 们 也 在 此 对 深 受 玩 家 喜 爱 的 《自 动 化》 金 曲 创 作 人 表 示 缅 怀</size> <size=1>唐人街 </size>";
			text4.text += "\n<size=20>www.kremlingames.com</size>";
			text3.text = "Александр·Егоров: stihi.ru/avtor/hhypest; Антон·Максимов: vk.com/mash2525\nЛейба: vk.com/leiba_anninsky и Дегтерёв: mayor-dgt.diary.ru\nДанил·Чемулов: vk.com/niceguy1331 и Денис·Роев: vk.com/id252659138\nNikolai·Aamand: Comrade Nikolai#0370; Югослав: vk.com/yugoslav1943\nMattia·Tuccelli: GattoNero#0161; Валентин·Потоцкий: vk.com/zerosensey\nВлад·Фомин: vk.com/vologodsky_pyotr_vasilevich; Anthony·Cawdrey\nИван·Елисеев: steamcommunity.com/id/eliseev999/\nАнатолий·Garlic·AAZ: youtube.com/user/AAZspb\nЛеонид·Чижиков: leonid.chizhikov@gmail.com; Роман·Мальков\nВасилий·Андреев: vk.com/brutalpin; Максим·Юрченко: vk.com/kiberhelim";
			text2.text = " 特 别 感 谢 ：Кузнецов·Илья - vk.com/id276119505\nДаниил·Чумаков; Виктор Гордеев; Денис Хистяев\nГеоргий Коршиков: vk.com/id455054985\nСтанислав·Волкович: vk.com/volkovichstanislav\nАлександр·Кучкин: vk.com/sachasaha\nhttps://steamcommunity.com/id/VERZERRTEST/\nScharfschutze: vk.com/id437154684\nЕгор Клюев: vk.com/trallshaman\nDavid52522; KeTsarl; GenosseNG; Taran Wood\nДмитрий Иванов: vk.com/kratos999god\nГеоргий Емельянов: vk.com/gogaa24\nГригорий Грибан: vk.com/id257939411";
		}
		else
		{
			text1.text = "<size=20><b>Китай: Наследие Мао</b></size>";
			text4.text = "<size=20>Василий Владимирович Костылев\nМаксим Олегович Чорнобук</size>";
			text4.text += "\n\n<size=20>В разработке проекта также участвовали:\nМаксим Косицын\nИлларион Солдаев\nВладимир Гридасов\n\nАвторская музыка:\nНикита Мишкевич\nСветлой памяти Никиты Мишкевича (27.02.1993-22.01.2023)</size>";
			text4.text += "\n\n<size=20>www.kremlingames.com</size>";
			text3.text = "Александр Егоров: stihi.ru/avtor/hhypest; Антон Максимов: vk.com/mash2525\nЛейба: vk.com/leiba_anninsky и Дегтерёв: mayor-dgt.diary.ru\nДанил Чемулов: vk.com/niceguy1331 и Денис Роев: vk.com/id252659138\nNikolai Aamand: Comrade Nikolai#0370; Югослав: vk.com/yugoslav1943\nMattia Tuccelli: GattoNero#0161; Валентин Потоцкий: vk.com/zerosensey\nВлад Фомин: vk.com/vologodsky_pyotr_vasilevich; Anthony Cawdrey\nИван Елисеев: steamcommunity.com/id/eliseev999/\nАнатолий Garlic AAZ: youtube.com/user/AAZspb\nЛеонид Чижиков: leonid.chizhikov@gmail.com; Роман Мальков\nВасилий Андреев: vk.com/brutalpin; Максим Юрченко: vk.com/kiberhelim";
			text2.text = "Особое спасибо: Кузнецов Илья - vk.com/id276119505\nДаниил Чумаков; Виктор Гордеев; Денис Хистяев\nГеоргий Коршиков: vk.com/id455054985\nСтанислав Волкович: vk.com/volkovichstanislav\nАлександр Кучкин: vk.com/sachasaha\nhttps://steamcommunity.com/id/VERZERRTEST/\nScharfschutze: vk.com/id437154684\nЕгор Клюев: vk.com/trallshaman\nDavid52522; KeTsarl; GenosseNG; Taran Wood\nДмитрий Иванов: vk.com/kratos999god\nГеоргий Емельянов: vk.com/gogaa24\nГригорий Грибан: vk.com/id257939411";
		}
	}
}
