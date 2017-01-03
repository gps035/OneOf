namespace OneOf.Tests
{
	public abstract class Response : OneOfBase<
		Response.MethodNotAllowed,
		Response.InvokeSuccessResponse
	>
	{
		public class MethodNotAllowed : Response { }

		public class InvokeSuccessResponse : Response { }
	}
}