using Adventure_Quest_RPG;
using System.Numerics;
using System;
namespace Adventure_Quest_RPG_Test
{
    public class UnitTest1
    {
        [Fact]
        public void EnemyHeathAfterAttack_IncrementalHealth()
        {
            //Arrange 
            var player1 = new Player("Boo");
            var monster = new RegularMonster("hi",50,30,20);
            int healthBefore = monster.Health;
            BattleSystem battleSystem = new BattleSystem();

            //Act
            battleSystem.Attack(player1, monster);

            //Assert 
            Assert.True(monster.Health < healthBefore);
        }

        [Fact]
        public void PlayerHealthAfterAttack_IncrementalHealth()
        {
            //Arrange 
            var player1 = new Player("Boo");
            var monster = new RegularMonster("boo",60,20,10);
            int healthBefore = monster.Health;
            BattleSystem battleSystem = new BattleSystem();

            //Act
            battleSystem.Attack(monster, player1);

            //Assert 
            Assert.False(player1.Health < healthBefore);
        }

        [Fact]
        public void winerHealthGraterThanZero()
        {
            //Arrange 
            var player1 = new Player("Boo");
            var monster = new RegularMonster("rex",90,70,8);
            BattleSystem battleSystem = new BattleSystem();

            //Act 
            var  isPlayerWin1 = battleSystem.StartBattle(player1, monster);

            //Assert
            if (isPlayerWin1)
            {
                Assert.True(player1.Health > 0);
            }
            else
            {
                Assert.True(monster.Health > 0);
            }
        }

    }
}