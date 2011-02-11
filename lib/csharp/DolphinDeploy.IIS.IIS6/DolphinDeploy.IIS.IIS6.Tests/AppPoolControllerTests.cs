using Xunit;

namespace DolphinDeploy.IIS.IIS6.Tests
{
    public class AppPoolControllerTests
    {
        [Fact]
        public void Can_create_app_pool()
        {
            AppPoolController poolControllerController = CreateController();
            poolControllerController.Create();

            Assert.True(poolControllerController.Exists());
        }

        [Fact]
        public void Exists_returns_false_if_not_created()
        {
            AppPoolController poolControllerController = CreateController();
            Assert.False(poolControllerController.Exists());
        }

        [Fact]
        public void Can_Delete_AppPool()
        {
            AppPoolController poolControllerController = CreateController();
            Assert.DoesNotThrow(poolControllerController.Delete);
        }

		[Fact]
		public void Can_Stop_AppPool() {
			AppPoolController poolController = CreateController();

			Assert.DoesNotThrow(poolController.Stop);
		}

		[Fact]
		public void Can_Start_AppPool() {
			AppPoolController poolController = CreateController();

			Assert.DoesNotThrow(poolController.Start);
		}

    	private AppPoolController CreateController()
        {
            var appController = new AppPoolController();
            appController.Server = "localhost";
            appController.Name = "MasterAppPool";

            return appController;
        }
    }
}