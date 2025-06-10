using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gacha : MonoBehaviour
{
    // Start is called before the first frame update
    int gachacount;
    void Start()
    {
        string[] array = new string[5]; // 총 5개를 배열 하겠다
        array[0] = "김예성"; // 1
        array[1] = "심승민"; // 2
        array[2] = "하상햔"; // 3
        array[3] = "김태연"; // 4
        array[4] = "이영은"; // 5
        // array[5] = "신효은"; // 불가능

        List<string> gachaT = new List<string>();
        gachaT.Add("대각선베기");
        gachaT.Add("발차기");
        gachaT.Add("수직베기");
    

    }


//    public enum SkillGrade
// {
//     Normal,
//     Rare,
//     Unique,
//     Legendary
// }

//     public class SwordSkill
//     {
//         public string Name { get; set; }
//         public string Description { get; set; }
//         public SkillGrade Grade { get; set; }

//         public SwordSkill(string name, string description, SkillGrade grade)
//         {
//             Name = name;
//             Description = description;
//             Grade = grade;
//         }
//     }

//     public class SwordSkillDatabase
// {
//     public static List<SwordSkill> AllSkills = new List<SwordSkill>()
//     {
//         // 🟩 Normal
//         new SwordSkill("바람베기", "바람처럼 빠르게 휘두르는 베기", SkillGrade.Normal),
//         new SwordSkill("곧은찌르기", "정면으로 똑바로 찌르는 기본기", SkillGrade.Normal),
//         new SwordSkill("세로가르기", "위에서 아래로 수직으로 가르기", SkillGrade.Normal),
//         new SwordSkill("옆베기", "좌우 횡으로 휘두르는 기술", SkillGrade.Normal),
//         new SwordSkill("도약베기", "살짝 점프하며 아래로 베기", SkillGrade.Normal),
//         new SwordSkill("가르기베기", "발끝에서 어깨까지 올려 베기", SkillGrade.Normal),
//         new SwordSkill("연속베기", "기본 베기를 두 번 연속 사용하는 기술", SkillGrade.Normal),
//         new SwordSkill("지르기치기", "찌르듯 휘두르는 강한 한 방", SkillGrade.Normal),
//         new SwordSkill("검끝돌리기", "검을 돌리며 다음 기술로 연결", SkillGrade.Normal),
//         new SwordSkill("후려치기", "위에서 아래로 세게 후려침", SkillGrade.Normal),

//         // 🟦 Rare
//         new SwordSkill("그림참", "그림자처럼 빠르고 잔상 남기는 일격", SkillGrade.Rare),
//         new SwordSkill("찬베기", "차가운 기운과 함께 묵직한 베기", SkillGrade.Rare),
//         new SwordSkill("번개찌르기", "순식간에 번개처럼 찌르는 기술", SkillGrade.Rare),
//         new SwordSkill("더블베기", "연속된 이단 베기", SkillGrade.Rare),
//         new SwordSkill("연쇄가르기", "사방으로 연속 회전하며 베기", SkillGrade.Rare),
//         new SwordSkill("꿰뚫기", "적의 방어를 꿰뚫는 강력 찌르기", SkillGrade.Rare),
//         new SwordSkill("틈치기", "적의 틈을 노려 약점을 베는 정밀기", SkillGrade.Rare),
//         new SwordSkill("견제베기", "거리 조절용, 밀쳐내는 용도의 베기", SkillGrade.Rare),
//         new SwordSkill("회전돌진", "검을 돌리며 전방으로 돌진 공격", SkillGrade.Rare),
//         new SwordSkill("낙하베기", "공중에서 착지하며 베는 기술", SkillGrade.Rare),

//         // 🟨 Unique
//         new SwordSkill("브라슬러시", "날카로운 힘이 응축된 찌르기", SkillGrade.Unique),
//         new SwordSkill("혈반파", "출혈을 유도하는 파열성 베기", SkillGrade.Unique),
//         new SwordSkill("쉐드브레이크", "방어를 깰 수 있는 어두운 일격", SkillGrade.Unique),
//         new SwordSkill("라스트윙", "검의 깃처럼 빠르게 날아드는 일격", SkillGrade.Unique),
//         new SwordSkill("카르니엘", "전설 속 기술서에 적힌 특수한 기술", SkillGrade.Unique),
//         new SwordSkill("모루참", "망치처럼 무겁고 둔중한 베기", SkillGrade.Unique),
//         new SwordSkill("루인엣지", "타격 후 시간차로 붕괴하는 일격", SkillGrade.Unique),
//         new SwordSkill("연기참", "공격 후 연기 효과로 회피 유도", SkillGrade.Unique),
//         new SwordSkill("응답참", "적 공격에 반응하여 발동되는 반격기", SkillGrade.Unique),
//         new SwordSkill("분열절", "맞은 적이 분열되듯 튕겨나가는 타격", SkillGrade.Unique),

//         // 🟧 Legendary
//         new SwordSkill("천상낙일", "하늘에서 떨어진 검처럼 광역으로 내려치는 일격", SkillGrade.Legendary),
//         new SwordSkill("운명절단", "대상의 운명을 끊는 상징적인 일격", SkillGrade.Legendary),
//         new SwordSkill("심연의 칼날", "심연의 어둠을 담아 베는 일격", SkillGrade.Legendary),
//         new SwordSkill("라그블레이크", "세계 붕괴와 함께 터지는 종말의 일격", SkillGrade.Legendary),
//         new SwordSkill("무혼참", "혼을 잃은 자만이 사용하는 무형의 검", SkillGrade.Legendary),
//         new SwordSkill("알카디아 참", "붉은 유성을 그리며 휘두르는 전설 기술", SkillGrade.Legendary),
//         new SwordSkill("페일데스", "창백한 죽음을 부르는 참격", SkillGrade.Legendary),
//         new SwordSkill("에리시움 파쇄", "봉인된 성역의 검을 해방하며 터뜨림", SkillGrade.Legendary),
//         new SwordSkill("절영무참", "보이지 않는 영역까지 파괴하는 궁극기", SkillGrade.Legendary),
//         new SwordSkill("최후의 상흔", "전투의 마지막 상처를 남기는 일격", SkillGrade.Legendary),
//     };
// }

    public void Gachasystem()
    {

        List<string> swordskill = new List<string>();
    // 🟩 Normal
        swordskill.Add("바람베기 - 바람처럼 빠르게 휘두르는 베기");
        swordskill.Add("곧은찌르기 - 정면으로 똑바로 찌르는 기본기");
        swordskill.Add("세로가르기 - 위에서 아래로 수직으로 가르기");
        swordskill.Add("옆베기 - 좌우 횡으로 휘두르는 기술");
        swordskill.Add("도약베기 - 살짝 점프하며 아래로 베기");
        swordskill.Add("가르기베기 - 발끝에서 어깨까지 올려 베기");
        swordskill.Add("연속베기 - 기본 베기를 두 번 연속 사용하는 기술");
        swordskill.Add("지르기치기 - 찌르듯 휘두르는 강한 한 방");
        swordskill.Add("검끝돌리기 - 검을 돌리며 다음 기술로 연결");
        swordskill.Add("후려치기 - 위에서 아래로 세게 후려침");

    // 🟦 Rare
        swordskill.Add("그림참 - 그림자처럼 빠르고 잔상 남기는 일격");
        swordskill.Add("찬베기 - 차가운 기운과 함께 묵직한 베기");
        swordskill.Add("번개찌르기 - 순식간에 번개처럼 찌르는 기술");
        swordskill.Add("더블베기 - 연속된 이단 베기");
        swordskill.Add("연쇄가르기 - 사방으로 연속 회전하며 베기");
        swordskill.Add("꿰뚫기 - 적의 방어를 꿰뚫는 강력 찌르기");
        swordskill.Add("틈치기 - 적의 틈을 노려 약점을 베는 정밀기");
        swordskill.Add("견제베기 - 거리 조절용, 밀쳐내는 용도의 베기");
        swordskill.Add("회전돌진 - 검을 돌리며 전방으로 돌진 공격");
        swordskill.Add("낙하베기 - 공중에서 착지하며 베는 기술");

    // 🟨 Unique
        swordskill.Add("브라슬러시 - 날카로운 힘이 응축된 찌르기");
        swordskill.Add("혈반파 - 출혈을 유도하는 파열성 베기");
        swordskill.Add("쉐드브레이크 - 방어를 깰 수 있는 어두운 일격");
        swordskill.Add("라스트윙 - 검의 깃처럼 빠르게 날아드는 일격");
        swordskill.Add("카르니엘 - 전설 속 기술서에 적힌 특수한 기술");
        swordskill.Add("모루참 - 망치처럼 무겁고 둔중한 베기");
        swordskill.Add("루인엣지 - 타격 후 시간차로 붕괴하는 일격");
        swordskill.Add("연기참 - 공격 후 연기 효과로 회피 유도");
        swordskill.Add("응답참 - 적 공격에 반응하여 발동되는 반격기");
        swordskill.Add("분열절 - 맞은 적이 분열되듯 튕겨나가는 타격");

// 🟧 Legendary
        swordskill.Add("천상낙일 - 하늘에서 떨어진 검처럼 광역으로 내려치는 일격");
        swordskill.Add("운명절단 - 대상의 운명을 끊는 상징적인 일격");
        swordskill.Add("심연의 칼날 - 심연의 어둠을 담아 베는 일격");
        swordskill.Add("라그블레이크 - 세계 붕괴와 함께 터지는 종말의 일격");
        swordskill.Add("무혼참 - 혼을 잃은 자만이 사용하는 무형의 검");
        swordskill.Add("알카디아 참 - 붉은 유성을 그리며 휘두르는 전설 기술");
        swordskill.Add("페일데스 - 창백한 죽음을 부르는 참격");
        swordskill.Add("에리시움 파쇄 - 봉인된 성역의 검을 해방하며 터뜨림");
        swordskill.Add("절영무참 - 보이지 않는 영역까지 파괴하는 궁극기");
        swordskill.Add("최후의 상흔 - 전투의 마지막 상처를 남기는 일격");

        int RandomGacha = Random.Range(1, 201);
        int LG = Random.Range(30, 39);
        int UG = Random.Range(20, 30);
        int RG = Random.Range(10, 20);
        int NG = Random.Range(0, 10);

        if (RandomGacha <= 3 || gachacount == 79)
        {
            Debug.Log($"픽업 {swordskill[39]} , 발동! ");
            gachacount = 0;
        }

        else if (RandomGacha <= 6)
        {
            Debug.Log($"전설 {swordskill[LG]} , 발동!");
            gachacount = 0;
        }

        else if (RandomGacha <= 16)
        {
            Debug.Log($"유니크 {swordskill[UG]} , 발동!");
            gachacount++;
        }

        else if (RandomGacha <= 46)
        {
            Debug.Log($"레어 {swordskill[RG]} , 발동!");
            gachacount++;
        }

        else
        {
            Debug.Log($"노말 {swordskill[NG]} , 발동!");
            gachacount++;
        }


    }

    public void tengacha()
    {
        for (int i = 0; i < 10; i++)
        {
            Gachasystem();
        }
        Debug.Log(gachacount);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
