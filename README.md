### README.md

National Geographic
=============
<details>
<summary>개발 환경</summary>  
<div markdown="1">
  
* C#
* MYSQL
</div>
</details>

<details>
<summary>등장 오브젝트</summary>
  
<div markdown="1">

* 캐릭터(8방향)　　![캐릭터](git_img/character_down.png)
![캐릭터](git_img/character_left.png)
![캐릭터](git_img/character_left_down.png)
![캐릭터](git_img/character_left_up.png)
![캐릭터](git_img/character_right.png)
![캐릭터](git_img/character_right_down.png)
![캐릭터](git_img/character_right_up.png)
![캐릭터](git_img/character_up.png)


* 몬스터 및 오브젝트 　　　
                 ![돼지](git_img/pig.png) : 돼지　
                 ![유령](git_img/ghost.png) : 유령　
                 ![나무](git_img/tree1.png) : 나무　
                 ![돌](git_img/stone.png) : 돌　

* 아이템 　　　　　　　
          ![고기](git_img/meat.png) : 고기　
           ![장작](git_img/firewood.png) : 장작　
           
           
* 조합 아이템 　　　
            ![횃불](git_img/handfirewood.png) : 횃불　
            ![돌도끼](git_img/weapon1.png) : 돌도끼　
            ![울타리](git_img/fence-0.png) : 울타리　

  

</div>
</details>


<details>
<summary>게임 설명</summary>
  
<div markdown="1">

### 몬스터와 어둠으로부터 살아남는 게임
+ 　　![캐릭터](git_img/character_down.png)의 상태는 배고픔, 정신, 체력이 있습니다.
+ 　　배고픔은 시간이 지날 수록 떨어집니다.
+ 　　배고픔이 일정값 이하로 내려갔을 경우 체력이 떨어집니다.            
+ 　　배고픔이 0이 되면 캐릭터는 사망합니다.
+ 　　![돼지](git_img/pig.png) 를 잡아 ![고기](git_img/meat.png) 를 얻어 체력과 배고픔을 +10 채울 수 있습니다.
+ 　　밤이 되면 정신 수치가 떨어집니다.
+ 　　![유령](git_img/ghost.png) 을 잡아 정신 수치를 회복할 수 있습니다.
+ 　　![울타리](git_img/fence-0.png)를 지어 집을 만들면 몬스터들로 부터 자신을 보호할 수 있습니다.
+ 　　나무는 ![나무1](git_img/tree1.png)　->　![나무2](git_img/tree2.png)　->　![나무3](git_img/tree3.png)　순으로 자랍니다.
+ 　　![나무3](git_img/tree3.png)　를 스페이스바로 공격 시 ![울타리](git_img/fence-0.png) , ![돌도끼](git_img/weapon1.png) ,  ![횃불](git_img/handfirewood.png) 의 재료인 ![장작](git_img/firewood.png) 을 획득할 수 있습니다.
+ 　　![바위](git_img/stone.png) 는 일정시간 마다 필드내 랜덤한 위치에 생성됩니다.
+ 　　모든 아이템은 키보드 Z키를 이용해 획득할 수 있습니다.


</div>
</details>




